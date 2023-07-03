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

    public partial class FrmAdminAddCourse : Form
    {
        private IHandleAddSemCourse handler;
        public FrmAdminAddCourse()
        {
            InitializeComponent();
            handler = new ProcessRequest();
        }

        private void FrmAdminAddCourse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.Instructors();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = handler.AddCourse(txb_admin_add_course_course_id.Text,
                txb_admin_add_course_name.Text,
                txb_admin_add_course_ins_id.Text,
                Convert.ToInt32(txb_admin_add_course_unit.Text),
                cmb_admin_add_course_field.Text,
                cmb_admin_add_course_sem.Text);
            MessageBox.Show(message);
        }
    }
}
