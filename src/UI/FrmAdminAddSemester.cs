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
    public partial class FrmAdminAddSemester : Form
    {
        private IHandleAddSemCourse handler;
        public FrmAdminAddSemester()
        {
            InitializeComponent();
            handler = new ProcessRequest();
        }

        private void btn_admin_add_sem_Click(object sender, EventArgs e)
        {
            string message = handler.AddSemester(txb_admin_add_sem_sem_id.Text,
                dtp_admin_add_sem_start.Text,
                dtp_admin_add_sem_end.Text,
                dtp_admin_add_sem_start_reg.Text,
                dtp_admin_add_sem_end_reg.Text);
            MessageBox.Show(message);
        }
    }
}
