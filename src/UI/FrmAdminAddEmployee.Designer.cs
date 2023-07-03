namespace FinalProjectUltimate.UI
{
    partial class FrmAdminAddEmployee
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
            this.btn_admin_add_emp = new System.Windows.Forms.Button();
            this.txb_admin_add_emp_username = new System.Windows.Forms.TextBox();
            this.txb_admin_add_emp_password = new System.Windows.Forms.TextBox();
            this.txb_admin_add_emp_firstname = new System.Windows.Forms.TextBox();
            this.txb_admin_add_emp_lastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_admin_add_emp
            // 
            this.btn_admin_add_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_add_emp.Location = new System.Drawing.Point(468, 26);
            this.btn_admin_add_emp.Name = "btn_admin_add_emp";
            this.btn_admin_add_emp.Size = new System.Drawing.Size(121, 80);
            this.btn_admin_add_emp.TabIndex = 44;
            this.btn_admin_add_emp.Text = "Add";
            this.btn_admin_add_emp.UseVisualStyleBackColor = true;
            this.btn_admin_add_emp.Click += new System.EventHandler(this.btn_admin_add_emp_Click);
            // 
            // txb_admin_add_emp_username
            // 
            this.txb_admin_add_emp_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_admin_add_emp_username.Location = new System.Drawing.Point(184, 12);
            this.txb_admin_add_emp_username.Name = "txb_admin_add_emp_username";
            this.txb_admin_add_emp_username.Size = new System.Drawing.Size(234, 26);
            this.txb_admin_add_emp_username.TabIndex = 43;
            // 
            // txb_admin_add_emp_password
            // 
            this.txb_admin_add_emp_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_admin_add_emp_password.Location = new System.Drawing.Point(184, 52);
            this.txb_admin_add_emp_password.Name = "txb_admin_add_emp_password";
            this.txb_admin_add_emp_password.Size = new System.Drawing.Size(234, 26);
            this.txb_admin_add_emp_password.TabIndex = 42;
            // 
            // txb_admin_add_emp_firstname
            // 
            this.txb_admin_add_emp_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_admin_add_emp_firstname.Location = new System.Drawing.Point(184, 94);
            this.txb_admin_add_emp_firstname.Name = "txb_admin_add_emp_firstname";
            this.txb_admin_add_emp_firstname.Size = new System.Drawing.Size(234, 26);
            this.txb_admin_add_emp_firstname.TabIndex = 41;
            // 
            // txb_admin_add_emp_lastname
            // 
            this.txb_admin_add_emp_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_admin_add_emp_lastname.Location = new System.Drawing.Point(184, 134);
            this.txb_admin_add_emp_lastname.Name = "txb_admin_add_emp_lastname";
            this.txb_admin_add_emp_lastname.Size = new System.Drawing.Size(234, 26);
            this.txb_admin_add_emp_lastname.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Username";
            // 
            // FrmAdminAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_admin_add_emp);
            this.Controls.Add(this.txb_admin_add_emp_username);
            this.Controls.Add(this.txb_admin_add_emp_password);
            this.Controls.Add(this.txb_admin_add_emp_firstname);
            this.Controls.Add(this.txb_admin_add_emp_lastname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminAddEmployee";
            this.Text = "FrmAdminAddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_admin_add_emp;
        private System.Windows.Forms.TextBox txb_admin_add_emp_username;
        private System.Windows.Forms.TextBox txb_admin_add_emp_password;
        private System.Windows.Forms.TextBox txb_admin_add_emp_firstname;
        private System.Windows.Forms.TextBox txb_admin_add_emp_lastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}