namespace FinalProjectUltimate.UI
{
    partial class FrmStudentChangePassword
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
            this.txb_stu_change_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_stu_change_password_confirm = new System.Windows.Forms.TextBox();
            this.btn_stu_change_password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_stu_change_password
            // 
            this.txb_stu_change_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_stu_change_password.Location = new System.Drawing.Point(240, 10);
            this.txb_stu_change_password.Name = "txb_stu_change_password";
            this.txb_stu_change_password.Size = new System.Drawing.Size(281, 34);
            this.txb_stu_change_password.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password";
            // 
            // txb_stu_change_password_confirm
            // 
            this.txb_stu_change_password_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_stu_change_password_confirm.Location = new System.Drawing.Point(240, 63);
            this.txb_stu_change_password_confirm.Name = "txb_stu_change_password_confirm";
            this.txb_stu_change_password_confirm.Size = new System.Drawing.Size(281, 34);
            this.txb_stu_change_password_confirm.TabIndex = 2;
            // 
            // btn_stu_change_password
            // 
            this.btn_stu_change_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stu_change_password.Location = new System.Drawing.Point(80, 113);
            this.btn_stu_change_password.Name = "btn_stu_change_password";
            this.btn_stu_change_password.Size = new System.Drawing.Size(367, 46);
            this.btn_stu_change_password.TabIndex = 4;
            this.btn_stu_change_password.Text = "Change Password";
            this.btn_stu_change_password.UseVisualStyleBackColor = true;
            this.btn_stu_change_password.Click += new System.EventHandler(this.btn_stu_change_password_Click);
            // 
            // FrmStudentChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 506);
            this.Controls.Add(this.btn_stu_change_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_stu_change_password_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_stu_change_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStudentChangePassword";
            this.Text = "FrmStudentChangePassword";
            this.Load += new System.EventHandler(this.FrmStudentChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_stu_change_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_stu_change_password_confirm;
        private System.Windows.Forms.Button btn_stu_change_password;
    }
}