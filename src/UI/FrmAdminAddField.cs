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
    
    public partial class FrmAdminAddField : Form
    {
        private IHandleAddSemCourse handler;
        public FrmAdminAddField()
        {
            InitializeComponent();
            handler = new ProcessRequest();
        }

        private void btn_admin_add_field_Click(object sender, EventArgs e)
        {
            string message = handler.AddField(txb_admin_add_course_field_id.Text, txb_admin_add_field_name.Text);
            MessageBox.Show(message);
        }
    }
}
