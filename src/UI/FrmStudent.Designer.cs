namespace FinalProjectUltimate.UI
{
    partial class FrmStudent
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
            this.pnl_student_main = new System.Windows.Forms.Panel();
            this.pnl_student_left = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_student_left.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_student_main
            // 
            this.pnl_student_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_student_main.Location = new System.Drawing.Point(179, 0);
            this.pnl_student_main.Name = "pnl_student_main";
            this.pnl_student_main.Size = new System.Drawing.Size(1025, 647);
            this.pnl_student_main.TabIndex = 5;
            this.pnl_student_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_student_main_Paint);
            // 
            // pnl_student_left
            // 
            this.pnl_student_left.Controls.Add(this.menuStrip1);
            this.pnl_student_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_student_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_student_left.Name = "pnl_student_left";
            this.pnl_student_left.Size = new System.Drawing.Size(179, 647);
            this.pnl_student_left.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.listOfCoursesToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(162, 647);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.informationToolStripMenuItem.Text = "General Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.registrationToolStripMenuItem.Text = "Registration";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // listOfCoursesToolStripMenuItem
            // 
            this.listOfCoursesToolStripMenuItem.Name = "listOfCoursesToolStripMenuItem";
            this.listOfCoursesToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.listOfCoursesToolStripMenuItem.Text = "Grades";
            this.listOfCoursesToolStripMenuItem.Click += new System.EventHandler(this.listOfCoursesToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 647);
            this.Controls.Add(this.pnl_student_main);
            this.Controls.Add(this.pnl_student_left);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.pnl_student_left.ResumeLayout(false);
            this.pnl_student_left.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_student_main;
        private System.Windows.Forms.Panel pnl_student_left;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}