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
    public partial class FrmStudent : Form
    {
        private IHandleStudentRequest handler;
        private string username;
        FrmStudentGeneralInformation frm_general;
        FrmStudentRegistration frm_reg;
        FrmStudentGrades frm_grades;
        FrmStudentChangePassword frm_change_password;
        public FrmStudent(string _username)
        {
            InitializeComponent();
            handler = new ProcessRequest();
            username = _username;
            frm_general = new FrmStudentGeneralInformation(username) { Dock = DockStyle.Fill, TopLevel = false};
            frm_reg = new FrmStudentRegistration(username, handler.LatestSemester(), handler.OneToLatestSemester()) { Dock = DockStyle.Fill, TopLevel = false };
            frm_grades = new FrmStudentGrades(username) { Dock = DockStyle.Fill, TopLevel = false };
            frm_change_password = new FrmStudentChangePassword(username) { Dock = DockStyle.Fill, TopLevel = false };
        }

        private void SetAllTopMostFalse()
        {
            frm_general.TopMost= false;
            frm_reg.TopMost= false;
            frm_grades.TopMost= false;
            frm_change_password.TopMost= false;
        }
        private void SetAllHide()
        {
            frm_general.Hide();
            frm_grades.Hide();
            frm_reg.Hide();
            frm_change_password.Hide();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            frm_general.TopMost = true;
            this.pnl_student_main.Controls.Add(frm_general);
            frm_general.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_reg.TopMost= true;
            this.pnl_student_main.Controls.Add(frm_reg);
            frm_reg.Show();
        }

        private void listOfCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllHide();
            SetAllTopMostFalse();
            frm_grades.TopMost= true;
            this.pnl_student_main.Controls.Add(frm_grades);
            frm_grades.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_general.TopMost = true;
            this.pnl_student_main.Controls.Add(frm_general);
            frm_general.Show();
        }

        private void pnl_student_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_change_password.TopMost = true;
            this.pnl_student_main.Controls.Add(frm_change_password);
            frm_change_password.Show();
        }
    }
}
