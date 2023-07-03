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
    public partial class FrmInstructorClasses : Form
    {
        private IHandleInstructorRequest handler;
        private string username;
        public FrmInstructorClasses(string username)
        {
            InitializeComponent();
            this.username = username;
            handler = new ProcessRequest();
        }

        private void FrmInstructorClasses_Load(object sender, EventArgs e)
        {
            cmb_ins_sem.DataSource = handler.Semesters();
        }

        private void cmb_ins_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ins_course.DataSource = handler.InstructorCoursesInSemester(username, cmb_ins_course.Text);
        }

        private void btn_ins_show_course_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.InstructorCoursesByStudentList(username, cmb_ins_course.Text, cmb_ins_sem.Text);
        }

        private void btn_ins_submit_grade_Click(object sender, EventArgs e)
        {
            string message = handler.SetFinalScore(username,
                txb_ins_student_id.Text,
                cmb_ins_course.Text,
                cmb_ins_sem.Text,
                Convert.ToDouble(nud_ins_grade.Value));
            MessageBox.Show(message);
        }
    }
}
