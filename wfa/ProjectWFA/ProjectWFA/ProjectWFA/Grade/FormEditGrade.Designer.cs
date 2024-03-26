namespace ProjectWFA.Grade
{
    partial class FormEditGrade
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
            this.final_grade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.final_grade)).BeginInit();
            this.SuspendLayout();
            // 
            // final_grade
            // 
            this.final_grade.Location = new System.Drawing.Point(25, 44);
            this.final_grade.Name = "final_grade";
            this.final_grade.Size = new System.Drawing.Size(100, 20);
            this.final_grade.TabIndex = 35;
            this.final_grade.ValueChanged += new System.EventHandler(this.final_grade_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Final Grade";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(25, 90);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 32;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // FormEditGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.final_grade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.save_btn);
            this.Name = "FormEditGrade";
            this.Text = "FormEditGrade";
            this.Load += new System.EventHandler(this.FormEditGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.final_grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown final_grade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button save_btn;
    }
}