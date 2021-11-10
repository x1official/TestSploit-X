using Auth.GG_Winform_Example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aitoheiwa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (API.Register(username.Text, password.Text, email.Text, license.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Register has been successful! Thank you for choosing Aitoheiwa! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
