namespace FinalProjectUltimate.UI
{
    partial class FrmInstructorClasses
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ins_sem = new System.Windows.Forms.ComboBox();
            this.cmb_ins_course = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_ins_student_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_ins_grade = new System.Windows.Forms.NumericUpDown();
            this.btn_ins_show_course = new System.Windows.Forms.Button();
            this.btn_ins_submit_grade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ins_grade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Course";
            // 
            // cmb_ins_sem
            // 
            this.cmb_ins_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ins_sem.FormattingEnabled = true;
            this.cmb_ins_sem.Location = new System.Drawing.Point(195, 6);
            this.cmb_ins_sem.Name = "cmb_ins_sem";
            this.cmb_ins_sem.Size = new System.Drawing.Size(221, 37);
            this.cmb_ins_sem.TabIndex = 41;
            this.cmb_ins_sem.SelectedIndexChanged += new System.EventHandler(this.cmb_ins_sem_SelectedIndexChanged);
            // 
            // cmb_ins_course
            // 
            this.cmb_ins_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ins_course.FormattingEnabled = true;
            this.cmb_ins_course.Location = new System.Drawing.Point(195, 58);
            this.cmb_ins_course.Name = "cmb_ins_course";
            this.cmb_ins_course.Size = new System.Drawing.Size(221, 37);
            this.cmb_ins_course.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 537);
            this.dataGridView1.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Student Id";
            // 
            // txb_ins_student_id
            // 
            this.txb_ins_student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ins_student_id.Location = new System.Drawing.Point(195, 235);
            this.txb_ins_student_id.Name = "txb_ins_student_id";
            this.txb_ins_student_id.Size = new System.Drawing.Size(221, 34);
            this.txb_ins_student_id.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Grade";
            // 
            // nud_ins_grade
            // 
            this.nud_ins_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_ins_grade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_ins_grade.Location = new System.Drawing.Point(195, 288);
            this.nud_ins_grade.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_ins_grade.Name = "nud_ins_grade";
            this.nud_ins_grade.Size = new System.Drawing.Size(120, 34);
            this.nud_ins_grade.TabIndex = 47;
            // 
            // btn_ins_show_course
            // 
            this.btn_ins_show_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ins_show_course.Location = new System.Drawing.Point(17, 112);
            this.btn_ins_show_course.Name = "btn_ins_show_course";
            this.btn_ins_show_course.Size = new System.Drawing.Size(241, 44);
            this.btn_ins_show_course.TabIndex = 48;
            this.btn_ins_show_course.Text = "Show Course";
            this.btn_ins_show_course.UseVisualStyleBackColor = true;
            this.btn_ins_show_course.Click += new System.EventHandler(this.btn_ins_show_course_Click);
            // 
            // btn_ins_submit_grade
            // 
            this.btn_ins_submit_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ins_submit_grade.Location = new System.Drawing.Point(17, 339);
            this.btn_ins_submit_grade.Name = "btn_ins_submit_grade";
            this.btn_ins_submit_grade.Size = new System.Drawing.Size(241, 44);
            this.btn_ins_submit_grade.TabIndex = 49;
            this.btn_ins_submit_grade.Text = "Submit Grade";
            this.btn_ins_submit_grade.UseVisualStyleBackColor = true;
            this.btn_ins_submit_grade.Click += new System.EventHandler(this.btn_ins_submit_grade_Click);
            // 
            // FrmInstructorClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 555);
            this.Controls.Add(this.btn_ins_submit_grade);
            this.Controls.Add(this.btn_ins_show_course);
            this.Controls.Add(this.nud_ins_grade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_ins_student_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_ins_course);
            this.Controls.Add(this.cmb_ins_sem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInstructorClasses";
            this.Text = "FrmInstructorClasses";
            this.Load += new System.EventHandler(this.FrmInstructorClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ins_grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ins_sem;
        private System.Windows.Forms.ComboBox cmb_ins_course;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_ins_student_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_ins_grade;
        private System.Windows.Forms.Button btn_ins_show_course;
        private System.Windows.Forms.Button btn_ins_submit_grade;
    }
}