namespace AttendanceSystem
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewMonthlyStatistics;
        private System.Windows.Forms.ListView listViewCourseProfessors;
        private System.Windows.Forms.Label labelMonthlyStatistics;
        private System.Windows.Forms.Label labelCourseProfessors;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Button buttonOpenForm5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listViewMonthlyStatistics = new System.Windows.Forms.ListView();
            this.listViewCourseProfessors = new System.Windows.Forms.ListView();
            this.labelMonthlyStatistics = new System.Windows.Forms.Label();
            this.labelCourseProfessors = new System.Windows.Forms.Label();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.buttonOpenForm5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMonthlyStatistics
            // 
            this.listViewMonthlyStatistics.Location = new System.Drawing.Point(20, 47);
            this.listViewMonthlyStatistics.Name = "listViewMonthlyStatistics";
            this.listViewMonthlyStatistics.Size = new System.Drawing.Size(752, 188);
            this.listViewMonthlyStatistics.View = System.Windows.Forms.View.Details;
            this.listViewMonthlyStatistics.FullRowSelect = true;
            this.listViewMonthlyStatistics.MultiSelect = false;
            this.listViewMonthlyStatistics.TabIndex = 0;
            // 
            // listViewCourseProfessors
            // 
            this.listViewCourseProfessors.Location = new System.Drawing.Point(20, 281);
            this.listViewCourseProfessors.Name = "listViewCourseProfessors";
            this.listViewCourseProfessors.Size = new System.Drawing.Size(752, 188);
            this.listViewCourseProfessors.View = System.Windows.Forms.View.Details;
            this.listViewCourseProfessors.FullRowSelect = true;
            this.listViewCourseProfessors.MultiSelect = false;
            this.listViewCourseProfessors.TabIndex = 1;
            // 
            // labelMonthlyStatistics
            // 
            this.labelMonthlyStatistics.AutoSize = true;
            this.labelMonthlyStatistics.Location = new System.Drawing.Point(20, 19);
            this.labelMonthlyStatistics.Name = "labelMonthlyStatistics";
            this.labelMonthlyStatistics.Size = new System.Drawing.Size(72, 15);
            this.labelMonthlyStatistics.TabIndex = 2;
            this.labelMonthlyStatistics.Text = "월간 통계";
            // 
            // labelCourseProfessors
            // 
            this.labelCourseProfessors.AutoSize = true;
            this.labelCourseProfessors.Location = new System.Drawing.Point(20, 253);
            this.labelCourseProfessors.Name = "labelCourseProfessors";
            this.labelCourseProfessors.Size = new System.Drawing.Size(122, 15);
            this.labelCourseProfessors.TabIndex = 3;
            this.labelCourseProfessors.Text = "과목별 담당 교수";
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(20, 500);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(150, 30);
            this.buttonGenerateReport.TabIndex = 4;
            this.buttonGenerateReport.Text = "보고서 출력";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // buttonOpenForm5
            // 
            this.buttonOpenForm5.Location = new System.Drawing.Point(200, 500);
            this.buttonOpenForm5.Name = "buttonOpenForm5";
            this.buttonOpenForm5.Size = new System.Drawing.Size(150, 30);
            this.buttonOpenForm5.TabIndex = 5;
            this.buttonOpenForm5.Text = "보고서 보기";
            this.buttonOpenForm5.UseVisualStyleBackColor = true;
            this.buttonOpenForm5.Click += new System.EventHandler(this.buttonOpenForm5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 651);
            this.Controls.Add(this.buttonOpenForm5);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.labelCourseProfessors);
            this.Controls.Add(this.labelMonthlyStatistics);
            this.Controls.Add(this.listViewCourseProfessors);
            this.Controls.Add(this.listViewMonthlyStatistics);
            this.Name = "Form4";
            this.Text = "월간 통계 및 담당 교수";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
