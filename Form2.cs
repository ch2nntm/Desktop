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
    public partial class frmEmployee : Form
    {
        private string edu, dept;

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAdd.Text = "";
            txtDate.Text = "";
            lstEdu.ClearSelected();
            cbDep.Text = "";
            btnClear.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Name is:" + txtName);
            MessageBox.Show("Employee Addr is:" + txtAdd);
            MessageBox.Show("Joined on:" + txtDate + " - Has education:" + lstEdu + " - Department:" + cbDep);
            btnClear.Enabled = true;
        }

        private void lstEdu_SelectedIndexChanged(object sender, EventArgs e)
        {
            edu = lstEdu.Text;
        }

        private void cbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            dept = cbDep.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmEmployee()
        {
            InitializeComponent();
        }

      
    }
}
