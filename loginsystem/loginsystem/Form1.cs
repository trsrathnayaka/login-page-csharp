using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_username.Text=="ransara" && tb_password.Text=="234")
            {

                Homepage hp = new Homepage();
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Message box!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
