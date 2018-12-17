using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelancer
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.loadPage();
            this.AddListUser();
        }

        public void loadPage()
        {
            webBrowser1.Navigate("http://10.149.34.168/ccbs/login.htm");

        }

        private void AddListUser()
        {
            richTextBox1.AppendText("\r\n dddd");
            richTextBox1.AppendText("\r\n dddd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object[] objArray = new Object[2];
            objArray[0] = "1";
            objArray[1] = "10";
            webBrowser1.Document.InvokeScript("test", objArray);

            webBrowser2.Document.InvokeScript("layds_thuebao2", objArray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://10.149.34.168/ccbs/main?1iutlomLork=vzzh5rgvnj5inutyu5otjk~");
        }

        public void login(string user, string pass)
        {
            var userElements = webBrowser1.Document.GetElementById("username");
            var passElements = webBrowser1.Document.GetElementById("passWord");
            var clickElements = webBrowser1.Document.GetElementById("btnLogin");
            userElements.InnerText = user;
            passElements.InnerText = pass;
            clickElements.InvokeMember("click");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            login(user, pass);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\script.txt");
            var x = File.ReadAllText(@"E:\script.txt");

            HtmlDocument doc = webBrowser2.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", x);
            head.AppendChild(s);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
