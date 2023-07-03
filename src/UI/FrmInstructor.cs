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
    public partial class FrmInstructor : Form
    {
        private string username;
        FrmStudentChangePassword frm_change_password;
        FrmInstructorClasses frm_classes;
        FrmInstructorGeneralInformation frm_general_information;
        public FrmInstructor(string _username)
        {
            InitializeComponent();
            username= _username;
            frm_change_password = new FrmStudentChangePassword(username);
            frm_classes = new FrmInstructorClasses(username);
            frm_general_information = new FrmInstructorGeneralInformation(username);
        }

        private void SetAllTopMostFalse()
        {
            frm_change_password.TopMost= false;
            frm_classes.TopMost= false;
            frm_general_information.TopMost= false;
        }
        private void SetAllHide()
        {
            frm_general_information.Hide();
            frm_classes.Hide();
            frm_change_password.Hide();
        }

        private void FrmInstructor_Load(object sender, EventArgs e)
        {

        }

        private void pnl_ins_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_general_information.TopMost = true;
            pnl_ins_main.Controls.Add(frm_general_information);
            frm_general_information.Show();
        }

        private void classesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_classes.TopMost = true;
            pnl_ins_main.Controls.Add(frm_classes);
            frm_classes.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_change_password.TopMost= true;
            pnl_ins_main.Controls.Add(frm_change_password);
            frm_change_password.Show();
        }
    }
}
