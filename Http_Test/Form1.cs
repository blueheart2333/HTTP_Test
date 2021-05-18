using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Http_Test //回调函数的用户层,执行输入等操作
{
    public partial class NetTest : Form
    {
        //int a, b, c;

        #region 控件列表
        //textHost
        //textConnection
        //textAccept
        //textOrigin
        //textUserAgentClient
        //textUserAgent
        //textReferer
        //textAcceptEncoding
        //textAcceptLanguage
        //textServer
        //textCookie
        #endregion

        public NetTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            

            check_text();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 设置窗口默认属性
            #endregion
            #region 设置控件默认值


            check_text();

            radioGet.Checked = true;

            #endregion

            Load_save();

            #region 设置焦点
            textURL.Focus();
            #endregion

            textHost.Text =  (0.1 + 0.2).ToString();

            

        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            
            TextBox textBox = (TextBox)sender;
            
            
        }

        public void check_text()
        {
            #region 绑定单选框与编辑框

            textHost.Enabled = checkHost.Checked == true ? true : false;

            textConnection.Enabled = checkConnection.Checked == true ? true : false;

            textAccept.Enabled = checkAccept.Checked == true ? true : false;

            textOrigin.Enabled = checkOrigin.Checked == true ? true : false;

            textUserAgentClient.Enabled = checkUserAgentClient.Checked == true ? true : false;

            textUserAgent.Enabled = checkUserAgent.Checked == true ? true : false;

            textReferer.Enabled = checkReferer.Checked == true ? true : false;

            textAcceptEncoding.Enabled = checkAcceptEncoding.Checked == true ? true : false;

            textAcceptLanguage.Enabled = checkAcceptLanguage.Checked == true ? true : false;

            textServer.Enabled = checkServer.Checked == true ? true : false;

            textCookie.Enabled = checkCookie.Checked == true ? true : false;

            textHeader.Enabled = checkHeader.Checked == true ? true : false;

            #endregion



        }
        public void Load_save()
        {
            textURL.Text = ConfigurationManager.AppSettings["textURL"];
            textHost.Text = ConfigurationManager.AppSettings["textHost"];
            textConnection.Text = ConfigurationManager.AppSettings["textConnection"];
            textAccept.Text = ConfigurationManager.AppSettings["textAccept"];
            textOrigin.Text = ConfigurationManager.AppSettings["textOrigin"];
            textUserAgentClient.Text = ConfigurationManager.AppSettings["textUserAgentClient"];
            textUserAgent.Text = ConfigurationManager.AppSettings["textUserAgent"];
            textReferer.Text = ConfigurationManager.AppSettings["textReferer"];
            textAcceptEncoding.Text = ConfigurationManager.AppSettings["textAcceptEncoding"];
            textAcceptLanguage.Text = ConfigurationManager.AppSettings["textAcceptLanguage"];
            textServer.Text = ConfigurationManager.AppSettings["textServer"];
            textCookie.Text = ConfigurationManager.AppSettings["textCookie"];
            textHeader.Text = ConfigurationManager.AppSettings["textHeader"];

            if (ConfigurationManager.AppSettings["Get"] == "True")
                radioGet.Checked = true;
            else radioPost.Checked = true;

            
            checkHost.Checked = ConfigurationManager.AppSettings["checkHost"] == "True" ? true : false;
            checkConnection.Checked = ConfigurationManager.AppSettings["checkConnection"] == "True" ? true : false;
            checkAccept.Checked = ConfigurationManager.AppSettings["checkAccept"] == "True" ? true : false;
            checkOrigin.Checked = ConfigurationManager.AppSettings["checkOrigin"] == "True" ? true : false;
            checkUserAgentClient.Checked = ConfigurationManager.AppSettings["checkUserAgentClient"] == "True" ? true : false;
            checkUserAgent.Checked = ConfigurationManager.AppSettings["checkUserAgent"] == "True" ? true : false;
            checkReferer.Checked = ConfigurationManager.AppSettings["checkReferer"] == "True" ? true : false;
            checkAcceptEncoding.Checked = ConfigurationManager.AppSettings["checkAcceptEncoding"] == "True" ? true : false;
            checkAcceptLanguage.Checked = ConfigurationManager.AppSettings["checkAcceptLanguage"] == "True" ? true : false;
            checkServer.Checked = ConfigurationManager.AppSettings["checkServer"] == "True" ? true : false;
            checkCookie.Checked = ConfigurationManager.AppSettings["checkCookie"] == "True" ? true : false;
            checkHeader.Checked = ConfigurationManager.AppSettings["checkHeader"] == "True" ? true : false;
        }

        public void SaveConfig()
        {
            Configuration CFG = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            CFG.AppSettings.Settings["textHost"].Value = textHost.Text;
            CFG.AppSettings.Settings["textConnection"].Value = textConnection.Text;
            CFG.AppSettings.Settings["textAccept"].Value = textAccept.Text;
            CFG.AppSettings.Settings["textOrigin"].Value = textOrigin.Text;
            CFG.AppSettings.Settings["textUserAgentClient"].Value = textUserAgentClient.Text;
            CFG.AppSettings.Settings["textUserAgent"].Value = textUserAgent.Text;
            CFG.AppSettings.Settings["textReferer"].Value = textReferer.Text;
            CFG.AppSettings.Settings["textAcceptEncoding"].Value = textAcceptEncoding.Text;
            CFG.AppSettings.Settings["textAcceptLanguage"].Value = textAcceptLanguage.Text;
            CFG.AppSettings.Settings["textServer"].Value = textServer.Text;
            CFG.AppSettings.Settings["textCookie"].Value = textCookie.Text;

            CFG.AppSettings.Settings["checkHost"].Value = checkHost.Checked.ToString();
            CFG.AppSettings.Settings["checkConnection"].Value = checkConnection.Checked.ToString();
            CFG.AppSettings.Settings["checkAccept"].Value = checkAccept.Checked.ToString();
            CFG.AppSettings.Settings["checkOrigin"].Value = checkOrigin.Checked.ToString();
            CFG.AppSettings.Settings["checkUserAgentClient"].Value = checkUserAgentClient.Checked.ToString();
            CFG.AppSettings.Settings["checkUserAgent"].Value = checkUserAgent.Checked.ToString();
            CFG.AppSettings.Settings["checkReferer"].Value = checkReferer.Checked.ToString();
            CFG.AppSettings.Settings["checkAcceptEncoding"].Value = checkAcceptEncoding.Checked.ToString();
            CFG.AppSettings.Settings["checkAcceptLanguage"].Value = checkAcceptLanguage.Checked.ToString();
            CFG.AppSettings.Settings["checkServer"].Value = checkServer.Checked.ToString();
            CFG.AppSettings.Settings["checkCookie"].Value = checkCookie.Checked.ToString();
            CFG.AppSettings.Settings["checkHeader"].Value = checkHeader.Checked.ToString();

            CFG.Save();
        }

        public TextBox CheckBoxToTextBox(CheckBox checkBox)//输入一个单选框,返回一个文本框
        {
            string checkboxname = checkBox.Name;
            
            string textboxname = checkboxname.Split()[0];
            foreach (Control item in this.Controls)//遍历所有控件,按控件名称返回
            {
                if (item.Name == textboxname)
                {
                    item.BackColor = Color.Red;
                    return (TextBox)item;
                }
                
            }
            return (TextBox)item;
        }
    }
        
}
