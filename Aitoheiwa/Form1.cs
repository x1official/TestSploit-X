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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (API.Login(username.Text, password.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                API.Log(User.Username, "Signed in");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }
    }
}
