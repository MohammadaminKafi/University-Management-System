using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinalProjectUltimate.HandlingIntefaces;

namespace FinalProjectUltimate.UI
{

    public partial class FrmAdmin : Form
    {
        IHandler handler;
        FrmAdminAddEmployee frm_add_employee = new FrmAdminAddEmployee() { Dock = DockStyle.Fill, TopLevel = false};
        FrmAdminAddInstructor frm_add_instructor = new FrmAdminAddInstructor() { Dock = DockStyle.Fill, TopLevel = false };
        FrmAdminAddStudent frm_add_student = new FrmAdminAddStudent() { Dock = DockStyle.Fill, TopLevel = false };
        FrmAdminAddCourse frm_add_course = new FrmAdminAddCourse() { Dock = DockStyle.Fill, TopLevel = false };
        FrmAdminAddSemester frm_add_sem = new FrmAdminAddSemester() { Dock = DockStyle.Fill, TopLevel = false };
        FrmAdminAddField frm_add_field = new FrmAdminAddField() { Dock = DockStyle.Fill, TopLevel = false };
        public FrmAdmin()
        {
            InitializeComponent();
            handler = new ProcessRequest();
        }

        private void SetAllTopMostFalse()
        {
            frm_add_student.TopMost = false;
            frm_add_instructor.TopMost = false;
            frm_add_employee.TopMost = false;
            frm_add_course.TopMost = false;
            frm_add_field.TopMost = false;
            frm_add_sem.TopMost = false;
        }
        private void SetAllHide()
        {
            frm_add_student.Hide();
            frm_add_instructor.Hide();
            frm_add_employee.Hide();
            frm_add_sem.Hide();
            frm_add_field.Hide();
            frm_add_course.Hide();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_add_student.TopMost= true;
            this.pnl_admin_main.Controls.Add(frm_add_student);
            frm_add_student.Show();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_add_instructor.TopMost= true;
            this.pnl_admin_main.Controls.Add(frm_add_instructor);
            frm_add_instructor.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_add_student.TopMost = true;
            this.pnl_admin_main.Controls.Add(frm_add_employee);
            frm_add_employee.Show();
        }

        private void semesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_add_sem.TopMost = true;
            this.pnl_admin_main.Controls.Add(frm_add_sem);
            frm_add_sem.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_add_course.TopMost = true;
            this.pnl_admin_main.Controls.Add(frm_add_course);
            frm_add_course.Show();
        }

        private void fieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllTopMostFalse();
            SetAllHide();
            frm_add_field.TopMost = true;
            this.pnl_admin_main.Controls.Add(frm_add_field);
            frm_add_field.Show();
        }
    }
}
