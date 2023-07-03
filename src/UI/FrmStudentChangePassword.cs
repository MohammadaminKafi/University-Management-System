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
    public partial class FrmStudentChangePassword : Form
    {
        private string username;
        private IHandleStudentRequest handler;

        public FrmStudentChangePassword(string _username)
        {
            InitializeComponent();
            this.username = _username;
            handler = new ProcessRequest();
        }

        private void FrmStudentChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_stu_change_password_Click(object sender, EventArgs e)
        {
            string message = "Confirm doesn't match";
            if (txb_stu_change_password.Text == txb_stu_change_password_confirm.Text)
            {
                message = handler.UserChangePassword(username, txb_stu_change_password.Text);
            }
            MessageBox.Show(message);
        }
    }
}
