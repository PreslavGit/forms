namespace ProjectWFA
{
    partial class FormGrade
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
            this.subject_cb = new System.Windows.Forms.ComboBox();
            this.final_grade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.student_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.final_grade)).BeginInit();
            this.SuspendLayout();
            // 
            // subject_cb
            // 
            this.subject_cb.FormattingEnabled = true;
            this.subject_cb.Location = new System.Drawing.Point(24, 32);
            this.subject_cb.Name = "subject_cb";
            this.subject_cb.Size = new System.Drawing.Size(100, 21);
            this.subject_cb.TabIndex = 29;
            // 
            // final_grade
            // 
            this.final_grade.Location = new System.Drawing.Point(24, 139);
            this.final_grade.Name = "final_grade";
            this.final_grade.Size = new System.Drawing.Size(100, 20);
            this.final_grade.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Final Grade";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(24, 185);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 25;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // student_cb
            // 
            this.student_cb.FormattingEnabled = true;
            this.student_cb.Location = new System.Drawing.Point(24, 86);
            this.student_cb.Name = "student_cb";
            this.student_cb.Size = new System.Drawing.Size(100, 21);
            this.student_cb.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Student";
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.student_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subject_cb);
            this.Controls.Add(this.final_grade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.save_btn);
            this.Name = "FormGrade";
            this.Text = "FormGrade";
            ((System.ComponentModel.ISupportInitialize)(this.final_grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subject_cb;
        private System.Windows.Forms.NumericUpDown final_grade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ComboBox student_cb;
        private System.Windows.Forms.Label label1;
    }
}