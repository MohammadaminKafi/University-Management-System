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
    public partial class FrmStudentGeneralInformation : Form
    {
        private string username;
        private IHandleStudentRequest handler;
        public FrmStudentGeneralInformation(string _username)
        {
            InitializeComponent();
            this.username = _username;
            handler = new ProcessRequest();
        }

        private void FrmStudentGeneralInformation_Load(object sender, EventArgs e)
        {
            IStudent student = handler.StudentGeneralInformation(username);
            lbl_stu_general_username.Text = student.Username;
            lbl_stu_general_fullname.Text = student.First_name + " " + student.Last_name;
            lbl_stu_general_field.Text = student.Field;
            lbl_stu_general_national_num.Text = student.National_number;
            txb_stu_general_phone_num.Text = student.Phone_number;
            txb_stu_general_email.Text = student.Email;
            txb_stu_general_city.Text = student.City;
            txb_stu_general_address.Text = student.Address;
            lbl_stu_general_average.Text = Convert.ToString(student.Overall_average);
            lbl_stu_general_units.Text = Convert.ToString(student.Total_passed_units);

        }

        private void btn_stu_update_info_Click(object sender, EventArgs e)
        {
            string message = handler.StudentChangeInformation(username,
                txb_stu_general_email.Text,
                txb_stu_general_phone_num.Text,
                dtp_stu_general_birth_date.Text,
                txb_stu_general_city.Text,
                txb_stu_general_address.Text);
            MessageBox.Show(message);
        }
    }
}
