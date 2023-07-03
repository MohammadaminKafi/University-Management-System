namespace FinalProjectUltimate.UI
{
    partial class FrmLogIn
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
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txb_login_username = new System.Windows.Forms.TextBox();
            this.txb_login_password = new System.Windows.Forms.TextBox();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(42, 37);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(150, 36);
            this.lbl_login_username.TabIndex = 0;
            this.lbl_login_username.Text = "Username";
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(42, 97);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(147, 36);
            this.lbl_login_password.TabIndex = 1;
            this.lbl_login_password.Text = "Password";
            // 
            // txb_login_username
            // 
            this.txb_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_login_username.Location = new System.Drawing.Point(214, 37);
            this.txb_login_username.Name = "txb_login_username";
            this.txb_login_username.Size = new System.Drawing.Size(211, 38);
            this.txb_login_username.TabIndex = 2;
            // 
            // txb_login_password
            // 
            this.txb_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_login_password.Location = new System.Drawing.Point(214, 97);
            this.txb_login_password.Name = "txb_login_password";
            this.txb_login_password.Size = new System.Drawing.Size(211, 38);
            this.txb_login_password.TabIndex = 3;
            // 
            // btn_login_login
            // 
            this.btn_login_login.Location = new System.Drawing.Point(48, 164);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(211, 49);
            this.btn_login_login.TabIndex = 4;
            this.btn_login_login.Text = "Log In";
            this.btn_login_login.UseVisualStyleBackColor = true;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 502);
            this.Controls.Add(this.btn_login_login);
            this.Controls.Add(this.txb_login_password);
            this.Controls.Add(this.txb_login_username);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.lbl_login_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogIn";
            this.Text = "FrmLogIn";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.TextBox txb_login_username;
        private System.Windows.Forms.TextBox txb_login_password;
        private System.Windows.Forms.Button btn_login_login;
    }
}