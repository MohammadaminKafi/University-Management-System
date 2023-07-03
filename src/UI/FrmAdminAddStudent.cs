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
    public partial class FrmAdminAddStudent : Form
    {
        IHandleAddStaff handler;
        IHandler big_boss = new ProcessRequest();
        public FrmAdminAddStudent()
        {
            InitializeComponent();
        }

        private void btn_admin_add_stu_Click(object sender, EventArgs e)
        {
            string message = handler.AddStudent(txb_admin_add_stu_username.Text,
                txb_admin_add_stu_password.Text,
                txb_admin_add_stu_firstname.Text,
                txb_admin_add_stu_lastname.Text,
                cmb_admin_add_stu_field.Text,
                txb_admin_add_stu_email.Text,
                txb_admin_add_stu_phone_num.Text,
                cmb_admin_add_stu_city.Text,
                txb_admin_add_stu_address.Text,
                txb_admin_add_stu_national_num.Text,
                dtp_admin_add_stu_birth_date.Text);
            MessageBox.Show(message);
        }

        private void FrmAdminAddStudent_Load(object sender, EventArgs e)
        {
            cmb_admin_add_stu_field.DataSource = big_boss.Fields();
        }
    }
}
