namespace AttendanceSystem
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewReports;
        private System.Windows.Forms.Button buttonViewReport;
        private System.Windows.Forms.Label labelReports;

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
            this.listViewReports = new System.Windows.Forms.ListView();
            this.buttonViewReport = new System.Windows.Forms.Button();
            this.labelReports = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewReports
            // 
            this.listViewReports.Location = new System.Drawing.Point(20, 47);
            this.listViewReports.Name = "listViewReports";
            this.listViewReports.Size = new System.Drawing.Size(450, 300);
            this.listViewReports.View = System.Windows.Forms.View.Details;
            this.listViewReports.FullRowSelect = true;
            this.listViewReports.MultiSelect = false;
            this.listViewReports.Columns.Add("보고서 이름", 250);
            this.listViewReports.Columns.Add("생성 날짜", 150);
            this.listViewReports.TabIndex = 0;
            // 
            // buttonViewReport
            // 
            this.buttonViewReport.Location = new System.Drawing.Point(20, 370);
            this.buttonViewReport.Name = "buttonViewReport";
            this.buttonViewReport.Size = new System.Drawing.Size(150, 30);
            this.buttonViewReport.TabIndex = 1;
            this.buttonViewReport.Text = "보고서 보기";
            this.buttonViewReport.UseVisualStyleBackColor = true;
            this.buttonViewReport.Click += new System.EventHandler(this.buttonViewReport_Click);
            // 
            // labelReports
            // 
            this.labelReports.AutoSize = true;
            this.labelReports.Location = new System.Drawing.Point(20, 19);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(87, 15);
            this.labelReports.TabIndex = 2;
            this.labelReports.Text = "저장된 보고서";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.labelReports);
            this.Controls.Add(this.buttonViewReport);
            this.Controls.Add(this.listViewReports);
            this.Name = "Form5";
            this.Text = "보고서 보기";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
