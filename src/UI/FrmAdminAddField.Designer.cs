namespace FinalProjectUltimate.UI
{
    partial class FrmAdminAddField
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
            this.txb_admin_add_field_name = new System.Windows.Forms.TextBox();
            this.txb_admin_add_course_field_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_admin_add_field = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_admin_add_field_name
            // 
            this.txb_admin_add_field_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_admin_add_field_name.Location = new System.Drawing.Point(189, 57);
            this.txb_admin_add_field_name.Name = "txb_admin_add_field_name";
            this.txb_admin_add_field_name.Size = new System.Drawing.Size(233, 34);
            this.txb_admin_add_field_name.TabIndex = 14;
            // 
            // txb_admin_add_course_field_id
            // 
            this.txb_admin_add_course_field_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_admin_add_course_field_id.Location = new System.Drawing.Point(189, 6);
            this.txb_admin_add_course_field_id.Name = "txb_admin_add_course_field_id";
            this.txb_admin_add_course_field_id.Size = new System.Drawing.Size(233, 34);
            this.txb_admin_add_course_field_id.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Field Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Field Id";
            // 
            // btn_admin_add_field
            // 
            this.btn_admin_add_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_add_field.Location = new System.Drawing.Point(30, 114);
            this.btn_admin_add_field.Name = "btn_admin_add_field";
            this.btn_admin_add_field.Size = new System.Drawing.Size(365, 52);
            this.btn_admin_add_field.TabIndex = 15;
            this.btn_admin_add_field.Text = "Add Field";
            this.btn_admin_add_field.UseVisualStyleBackColor = true;
            this.btn_admin_add_field.Click += new System.EventHandler(this.btn_admin_add_field_Click);
            // 
            // FrmAdminAddField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 509);
            this.Controls.Add(this.btn_admin_add_field);
            this.Controls.Add(this.txb_admin_add_field_name);
            this.Controls.Add(this.txb_admin_add_course_field_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminAddField";
            this.Text = "FrmAdminAddField";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_admin_add_field_name;
        private System.Windows.Forms.TextBox txb_admin_add_course_field_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin_add_field;
    }
}