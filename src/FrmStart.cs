using FinalProjectUltimate.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinalProjectUltimate.Additionals;
using System.Security.Policy;

namespace FinalProjectUltimate
{
    public partial class FrmStart : Form
    {
        IHandler handler;
        public FrmStart()
        {
            InitializeComponent();
            handler = new ProcessRequest();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            FrmLogIn frm_login = new FrmLogIn() { Dock = DockStyle.Fill, TopLevel=false, TopMost=true};
            this.pnl_start_main.Controls.Add(frm_login);
            frm_login.Show();
        }
    }
}
