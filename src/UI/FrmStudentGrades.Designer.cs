namespace FinalProjectUltimate.UI
{
    partial class FrmStudentGrades
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
            this.btn_stu_grades = new System.Windows.Forms.Button();
            this.dgv_stu_grades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_stu_reg_semester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu_grades)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_stu_grades
            // 
            this.btn_stu_grades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stu_grades.Location = new System.Drawing.Point(364, 10);
            this.btn_stu_grades.Name = "btn_stu_grades";
            this.btn_stu_grades.Size = new System.Drawing.Size(151, 37);
            this.btn_stu_grades.TabIndex = 7;
            this.btn_stu_grades.Text = "Show Grades";
            this.btn_stu_grades.UseVisualStyleBackColor = true;
            this.btn_stu_grades.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_stu_grades
            // 
            this.dgv_stu_grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stu_grades.Location = new System.Drawing.Point(12, 64);
            this.dgv_stu_grades.Name = "dgv_stu_grades";
            this.dgv_stu_grades.RowHeadersWidth = 51;
            this.dgv_stu_grades.RowTemplate.Height = 24;
            this.dgv_stu_grades.Size = new System.Drawing.Size(890, 383);
            this.dgv_stu_grades.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Semester";
            // 
            // cmb_stu_reg_semester
            // 
            this.cmb_stu_reg_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stu_reg_semester.FormattingEnabled = true;
            this.cmb_stu_reg_semester.Location = new System.Drawing.Point(130, 10);
            this.cmb_stu_reg_semester.Name = "cmb_stu_reg_semester";
            this.cmb_stu_reg_semester.Size = new System.Drawing.Size(210, 37);
            this.cmb_stu_reg_semester.TabIndex = 4;
            // 
            // FrmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 507);
            this.Controls.Add(this.btn_stu_grades);
            this.Controls.Add(this.dgv_stu_grades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_stu_reg_semester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStudentGrades";
            this.Text = "FrmStudentGrades";
            this.Load += new System.EventHandler(this.FrmStudentGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu_grades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stu_grades;
        private System.Windows.Forms.DataGridView dgv_stu_grades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_stu_reg_semester;
    }
}