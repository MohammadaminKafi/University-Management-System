namespace FinalProjectUltimate.UI
{
    partial class FrmInstructor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_ins_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ins_main
            // 
            this.pnl_ins_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_ins_main.Location = new System.Drawing.Point(203, 0);
            this.pnl_ins_main.Name = "pnl_ins_main";
            this.pnl_ins_main.Size = new System.Drawing.Size(929, 654);
            this.pnl_ins_main.TabIndex = 4;
            this.pnl_ins_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_ins_main_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 654);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalInformationToolStripMenuItem,
            this.classesListToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(162, 654);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalInformationToolStripMenuItem
            // 
            this.generalInformationToolStripMenuItem.Name = "generalInformationToolStripMenuItem";
            this.generalInformationToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.generalInformationToolStripMenuItem.Text = "General Information";
            this.generalInformationToolStripMenuItem.Click += new System.EventHandler(this.generalInformationToolStripMenuItem_Click);
            // 
            // classesListToolStripMenuItem
            // 
            this.classesListToolStripMenuItem.Name = "classesListToolStripMenuItem";
            this.classesListToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.classesListToolStripMenuItem.Text = "Classes List";
            this.classesListToolStripMenuItem.Click += new System.EventHandler(this.classesListToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // FrmInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 654);
            this.Controls.Add(this.pnl_ins_main);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInstructor";
            this.Text = "FrmInstructor";
            this.Load += new System.EventHandler(this.FrmInstructor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_ins_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}