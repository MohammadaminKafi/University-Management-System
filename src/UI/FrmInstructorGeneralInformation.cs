using FinalProjectUltimate.HandlingIntefaces;
using FinalProjectUltimate.Interfaces;
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
    public partial class FrmInstructorGeneralInformation : Form
    {
        private IHandleInstructorRequest handler;
        private string username;
        public FrmInstructorGeneralInformation(string _username)
        {
            InitializeComponent();
            this.username = _username;
            handler = new ProcessRequest();
        }

        private void FrmInstructorGeneralInformation_Load(object sender, EventArgs e)
        {
            IInstructor instructor = handler.InstructorGeneralInformation(username);
            lbl_ins_general_username.Text = instructor.Username;
            lbl_ins_general_fullname.Text = instructor.First_name + " " + instructor.Last_name;
            lbl_ins_general_field.Text = instructor.Field;
            txb_ins_general_email.Text = instructor.Email;
        }

        private void btn_ins_update_info_Click(object sender, EventArgs e)
        {
            string message = handler.InstructorChangeInformation(username, txb_ins_general_email.Text);
            MessageBox.Show(message);
        }
    }
}
