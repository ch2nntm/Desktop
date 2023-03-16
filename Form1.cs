using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbUS_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtUS.Text.Equals("Admin"))
            {
                if (this.txtPW.Text.Equals("Admin"))
                {
                    frmEmployee employ = new frmEmployee();
                    employ.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Password is invalid");
            }
            else
                MessageBox.Show("User Name is invalid");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
