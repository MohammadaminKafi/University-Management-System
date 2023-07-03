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
    public partial class FrmAdminAddInstructor : Form
    {
        IHandleAddStaff handler;
        public FrmAdminAddInstructor()
        {
            InitializeComponent();
            handler = new ProcessRequest();
        }

        private void FrmAdminAddInstructor_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_admin_add_ins_Click(object sender, EventArgs e)
        {
            string message = handler.AddInstructor(txb_admin_add_ins_username.Text,
                txb_admin_add_ins_password.Text,
                txb_admin_add_ins_firstname.Text,
                txb_admin_add_ins_lastname.Text,
                cmb_admin_add_ins_field.Text,
                txb_admin_add_ins_email.Text);
            MessageBox.Show(message);
        }
    }
}
