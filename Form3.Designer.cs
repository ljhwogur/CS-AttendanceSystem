namespace AttendanceSystem
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label labelTotalPresent;
        private System.Windows.Forms.Label labelTotalLates;
        private System.Windows.Forms.Label labelTotalAbsences;
        private System.Windows.Forms.Label labelAttendanceRate;

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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.labelTotalPresent = new System.Windows.Forms.Label();
            this.labelTotalLates = new System.Windows.Forms.Label();
            this.labelTotalAbsences = new System.Windows.Forms.Label();
            this.labelAttendanceRate = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(20, 20);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(200, 160);
            this.listBoxStudents.TabIndex = 0;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);

            // 
            // labelTotalPresent
            // 
            this.labelTotalPresent.AutoSize = true;
            this.labelTotalPresent.Location = new System.Drawing.Point(250, 20);
            this.labelTotalPresent.Name = "labelTotalPresent";
            this.labelTotalPresent.Size = new System.Drawing.Size(90, 16);
            this.labelTotalPresent.TabIndex = 1;
            this.labelTotalPresent.Text = "총 출석 일수: ";

            // 
            // labelTotalLates
            // 
            this.labelTotalLates.AutoSize = true;
            this.labelTotalLates.Location = new System.Drawing.Point(250, 50);
            this.labelTotalLates.Name = "labelTotalLates";
            this.labelTotalLates.Size = new System.Drawing.Size(90, 16);
            this.labelTotalLates.TabIndex = 2;
            this.labelTotalLates.Text = "총 지각 일수: ";

            // 
            // labelTotalAbsences
            // 
            this.labelTotalAbsences.AutoSize = true;
            this.labelTotalAbsences.Location = new System.Drawing.Point(250, 80);
            this.labelTotalAbsences.Name = "labelTotalAbsences";
            this.labelTotalAbsences.Size = new System.Drawing.Size(90, 16);
            this.labelTotalAbsences.TabIndex = 3;
            this.labelTotalAbsences.Text = "총 결석 일수: ";

            // 
            // labelAttendanceRate
            // 
            this.labelAttendanceRate.AutoSize = true;
            this.labelAttendanceRate.Location = new System.Drawing.Point(250, 110);
            this.labelAttendanceRate.Name = "labelAttendanceRate";
            this.labelAttendanceRate.Size = new System.Drawing.Size(70, 16);
            this.labelAttendanceRate.TabIndex = 4;
            this.labelAttendanceRate.Text = "출석률: ";

            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.labelAttendanceRate);
            this.Controls.Add(this.labelTotalAbsences);
            this.Controls.Add(this.labelTotalLates);
            this.Controls.Add(this.labelTotalPresent);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "Form3";
            this.Text = "출석 통계";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
