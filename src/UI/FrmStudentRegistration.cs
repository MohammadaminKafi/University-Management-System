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
    public partial class FrmStudentRegistration : Form
    {
        private string username;
        private string current_semester_id;
        private string previous_semester_id;
        private IHandleStudentRequest handler;
        public FrmStudentRegistration(string _username, string _current_semester_id, string _previous_semester_id)
        {
            InitializeComponent();
            this.username = _username;
            this.current_semester_id = _current_semester_id;
            this.previous_semester_id = _previous_semester_id;
            handler = new ProcessRequest();
        }

        private void FrmStudentRegistration_Load(object sender, EventArgs e)
        {
            lbl_stu_reg_semester.Text = current_semester_id;
            dgv_stu_reg_available_courses.DataSource = handler.courses(current_semester_id);
            dgv_stu_reg_current_courses.DataSource = handler.StudentGrades(username, current_semester_id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = handler.StudentRegistration(username, txb_stu_reg_course_id.Text, current_semester_id, previous_semester_id);

            MessageBox.Show(message);

            dgv_stu_reg_available_courses.DataSource = handler.courses(current_semester_id);
            dgv_stu_reg_current_courses.DataSource = handler.StudentGrades(username, current_semester_id);
        }
    }
}
