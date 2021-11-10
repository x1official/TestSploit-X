using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;


namespace Aitoheiwa
{
    public partial class Main : Form
    {

        ExploitAPI cute = new ExploitAPI();

        public Main()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(string.Format("file:///{0}ace/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            cute.SendLuaScript(script);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            cute.LaunchExploit();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("SetText", new object[]
                   {
                        ""
                   });
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string MainText = File.ReadAllText(Functions.openfiledialog.FileName);
                    webBrowser1.Document.InvokeScript("SetText", new object[]
                    {
                          MainText
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
