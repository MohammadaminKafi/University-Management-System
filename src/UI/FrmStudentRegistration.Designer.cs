namespace FinalProjectUltimate.UI
{
    partial class FrmStudentRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_stu_reg_semester = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_stu_reg_course_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_stu_reg_available_courses = new System.Windows.Forms.DataGridView();
            this.dgv_stu_reg_current_courses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu_reg_available_courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu_reg_current_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester";
            // 
            // lbl_stu_reg_semester
            // 
            this.lbl_stu_reg_semester.AutoSize = true;
            this.lbl_stu_reg_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stu_reg_semester.Location = new System.Drawing.Point(191, 9);
            this.lbl_stu_reg_semester.Name = "lbl_stu_reg_semester";
            this.lbl_stu_reg_semester.Size = new System.Drawing.Size(117, 29);
            this.lbl_stu_reg_semester.TabIndex = 1;
            this.lbl_stu_reg_semester.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course id";
            // 
            // txb_stu_reg_course_id
            // 
            this.txb_stu_reg_course_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_stu_reg_course_id.Location = new System.Drawing.Point(196, 45);
            this.txb_stu_reg_course_id.Name = "txb_stu_reg_course_id";
            this.txb_stu_reg_course_id.Size = new System.Drawing.Size(187, 34);
            this.txb_stu_reg_course_id.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(446, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_stu_reg_available_courses
            // 
            this.dgv_stu_reg_available_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stu_reg_available_courses.Location = new System.Drawing.Point(17, 131);
            this.dgv_stu_reg_available_courses.Name = "dgv_stu_reg_available_courses";
            this.dgv_stu_reg_available_courses.RowHeadersWidth = 51;
            this.dgv_stu_reg_available_courses.RowTemplate.Height = 24;
            this.dgv_stu_reg_available_courses.Size = new System.Drawing.Size(577, 429);
            this.dgv_stu_reg_available_courses.TabIndex = 5;
            this.dgv_stu_reg_available_courses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv_stu_reg_current_courses
            // 
            this.dgv_stu_reg_current_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stu_reg_current_courses.Location = new System.Drawing.Point(613, 131);
            this.dgv_stu_reg_current_courses.Name = "dgv_stu_reg_current_courses";
            this.dgv_stu_reg_current_courses.RowHeadersWidth = 51;
            this.dgv_stu_reg_current_courses.RowTemplate.Height = 24;
            this.dgv_stu_reg_current_courses.Size = new System.Drawing.Size(301, 429);
            this.dgv_stu_reg_current_courses.TabIndex = 6;
            // 
            // FrmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 572);
            this.Controls.Add(this.dgv_stu_reg_current_courses);
            this.Controls.Add(this.dgv_stu_reg_available_courses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_stu_reg_course_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_stu_reg_semester);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStudentRegistration";
            this.Text = "FrmStudentRegistration";
            this.Load += new System.EventHandler(this.FrmStudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu_reg_available_courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu_reg_current_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_stu_reg_semester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_stu_reg_course_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_stu_reg_available_courses;
        private System.Windows.Forms.DataGridView dgv_stu_reg_current_courses;
    }
}