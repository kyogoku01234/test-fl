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
            string name = "tuyennt_hcm";
            string script = "var Objects=new Array,Fields=new Array,pNum=1,pRec=10,iFlag=1;function form_load(){Objects=[\"txtSoTB\",\"cboLoaiSo\",\"cmdTimkiem\"],Fields=[\"SO_TB\",\"KIEU_SO\",null],change_subrange(),check_flag()}function getDsKHoa(){DataRemoting.getDoc('neo.numstore.doc_layds_khoa(\""+name+"\")',DOC_layds_khoa)}var DOC_layds_khoa=function(o){$(\"ajaxKhoa\").innerHTML=o};function check_flag(){DataRemoting.getValue(\"neo.numstore.doc_flag(5)\",flag_func)}var flag_func=function(o){iFlag=\"1\"==o?1:2};function layds_thuebao2(o,e){if(check_flag(),1==iFlag)if(1==$(\"cboTrangthai\").value)var a='neo.numstore.doc_layds_thuebao_dk(\"'+$(\"txtSoTB\").value+'\",\"'+$(\"cboLoaiSo\").value+'\",\"'+$(\"cboSubRange\").value+'\",\"'+$(\"cboTrangthai\").value+'\",\""+name+"\",\"'+o+'\",\"'+e+'\")';else a='neo.numstore.doc_layds_thuebao_1(\"'+$(\"txtSoTB\").value+'\",\"'+$(\"cboLoaiSo\").value+'\",\"'+$(\"cboSubRange\").value+'\",\"'+$(\"cboTrangthai\").value+'\",\""+name+"\",\"'+o+'\",\"'+e+'\")';else a='neo.numstore.doc_layds_thuebao_api(\"'+$(\"txtSoTB\").value+'\",\"'+$(\"cboLoaiSo\").value+'\",\"'+$(\"cboSubRange\").value+'\",\"'+$(\"cboTrangthai\").value+'\",\""+name+"\",\"'+o+'\",\"'+e+'\")';pNum=o,pRec=e,$(\"ajaxKetqua\").style.height=0,DataRemoting.getDoc(a,DOC_layds_thuebao),$(\"lblKetqua\").innerHTML=\"<font color=red><b>&#272;ang th&#7921;c hi&#7879;n ...</b></font>\"}var DOC_layds_thuebao=function(o){if($(\"ajaxKetqua\").style.height=0,$(\"ajaxKetqua\").innerHTML=o,1==iFlag)var e='neo.numstore.doc_layth_thuebao(\"'+$(\"txtSoTB\").value+'\",\"'+$(\"cboLoaiSo\").value+'\",\"'+pNum+'\",\"'+pRec+'\")';else e='neo.numstore.doc_layth_thuebao_api(\"'+pNum+'\",\"'+pRec+'\")';DataRemoting.getDoc(e,DOC_layth_thuebao)},DOC_layth_thuebao=function(o){$(\"ajaxKetquaTH\").innerHTML=o,$(\"lblKetqua\").innerHTML=\"\"};function foward_dangky(o,e,a,n,t,u,i){0==i?window.location=\"/ccbs/main?1y\u007fyezksvrgzkelork=rg\u007fu{z5iihy5zvreiihy&1iutlomLork=rgvvnok{5otjk~&yuezh=\"+o+\"&zkteqok{yu=\"+Url.encode_1252(e)+\"&i{uiezuoznok{=\"+Url.encode_1252(a)+\"&zmey{j{tm=\"+Url.encode_1252(n)+\"&jgziui=\"+Url.encode_1252(t)+\"&notnzn{iens=\"+Url.encode_1252(u):alert(Url.decode_1252(\"Thu&#234; bao &#273;&#227; &#273;&#259;ng k&#253;\"))}function foward_thongtin(o,e){1==e?(openWindow(\"frmthongtin\",\"/ccbs/main?1iutlomLork=jgtmq\u007f5lxsznutmzot&yuezh=\"+o,\"frmthongtin\",500,150,\"menubar=no,toolbar=no,location=no,status=yes,scrollbars=no,resizable=yes\"),frmkmtc.focus()):alert(\"Thue bao dang trong kho! \")}function forward_chitiet_tintuc(o){window.location=\"/ccbs/main?1y\u007fyezksvrgzkelork=rg\u007fu{z5iihy5zvreiihy&1iutlomLork=zotz{i5otjk~&tk}eoj=\"+o}function change_subrange(){var o='neo.numstore.doc_layds_kieuso_new(\"'+$(\"cboSubRange\").value+'\")';DataRemoting.getDoc(o,function(o){$(\"kieuso_s\").innerHTML=o})}";

            HtmlDocument doc = webBrowser2.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", script);
            head.AppendChild(s);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
