using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        }

        public void loadPage()
        {
            webBrowser1.Navigate("http://10.149.34.168/ccbs/login.htm");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var x = webBrowser1.Version;           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://10.149.34.168/ccbs/main?1iutlomLork=vzzh5rgvnj5inutyu5otjk~");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            var userElements = webBrowser1.Document.GetElementById("username");
            var passElements = webBrowser1.Document.GetElementById("passWord");
            var clickElements = webBrowser1.Document.GetElementById("btnLogin");
            userElements.InnerText = user;
            passElements.InnerText = pass;
            clickElements.InvokeMember("click");
        }
    }
}
