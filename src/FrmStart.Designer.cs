namespace FinalProjectUltimate
{
    partial class FrmStart
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
            this.pnl_start_left = new System.Windows.Forms.Panel();
            this.pnl_start_main = new System.Windows.Forms.Panel();
            this.pnl_start_top = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_start_left
            // 
            this.pnl_start_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_start_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_start_left.Name = "pnl_start_left";
            this.pnl_start_left.Size = new System.Drawing.Size(141, 472);
            this.pnl_start_left.TabIndex = 0;
            // 
            // pnl_start_main
            // 
            this.pnl_start_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_start_main.Location = new System.Drawing.Point(141, 84);
            this.pnl_start_main.Name = "pnl_start_main";
            this.pnl_start_main.Size = new System.Drawing.Size(933, 388);
            this.pnl_start_main.TabIndex = 1;
            // 
            // pnl_start_top
            // 
            this.pnl_start_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_start_top.Location = new System.Drawing.Point(141, 0);
            this.pnl_start_top.Name = "pnl_start_top";
            this.pnl_start_top.Size = new System.Drawing.Size(933, 86);
            this.pnl_start_top.TabIndex = 2;
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 472);
            this.Controls.Add(this.pnl_start_top);
            this.Controls.Add(this.pnl_start_main);
            this.Controls.Add(this.pnl_start_left);
            this.Name = "FrmStart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_start_left;
        private System.Windows.Forms.Panel pnl_start_main;
        private System.Windows.Forms.Panel pnl_start_top;
    }
}

