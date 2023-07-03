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
    public partial class FrmLogIn : Form
    {
        IHandler handler;
        public FrmLogIn()
        {
            InitializeComponent();
            handler = new ProcessRequest();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_login_Click(object sender, EventArgs e)
        {
            string message = handler.LogIn(txb_login_username.Text, txb_login_password.Text);
            string role;
            if (message == "Succesful log in!")
            {
                role = handler.Role(txb_login_username.Text);

                if (role == "admin")
                {
                    FrmAdmin frm_admin = new FrmAdmin();
                    frm_admin.Show();
                }
                else if (role == "student")
                {
                    FrmStudent frm_student = new FrmStudent(txb_login_username.Text);
                    frm_student.Show();
                }
                else if (role == "instructor")
                {

                }
                else if (role == "employee")
                {

                }
                else
                {

                }
            }
            //MessageBox.Show(message);
        }
    }
}
