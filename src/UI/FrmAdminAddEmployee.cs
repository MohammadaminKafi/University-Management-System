using FinalProjectUltimate.HandlingIntefaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectUltimate.UI
{
    public partial class FrmAdminAddEmployee : Form
    {
        IHandleAddStaff handler;
        public FrmAdminAddEmployee()
        {
            InitializeComponent();
            handler = new ProcessRequest();
        }

        private void btn_admin_add_emp_Click(object sender, EventArgs e)
        {
            string message = handler.AddEmployee(txb_admin_add_emp_username.Text,
                txb_admin_add_emp_password.Text,
                txb_admin_add_emp_firstname.Text,
                txb_admin_add_emp_lastname.Text);
            MessageBox.Show(message);
        }
    }
}
