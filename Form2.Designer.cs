using System;

namespace AttendanceSystem
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.RadioButton radioButtonPresent;
        private System.Windows.Forms.RadioButton radioButtonLate;
        private System.Windows.Forms.RadioButton radioButtonAbsent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelAttendanceStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;

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
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.radioButtonPresent = new System.Windows.Forms.RadioButton();
            this.radioButtonLate = new System.Windows.Forms.RadioButton();
            this.radioButtonAbsent = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelAttendanceStatus = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();

            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(20, 40);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(200, 160);
            this.listBoxStudents.TabIndex = 0;

            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(240, 40);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCourses.TabIndex = 1;

            // 
            // radioButtonPresent
            // 
            this.radioButtonPresent.AutoSize = true;
            this.radioButtonPresent.Location = new System.Drawing.Point(240, 90);
            this.radioButtonPresent.Name = "radioButtonPresent";
            this.radioButtonPresent.Size = new System.Drawing.Size(65, 20);
            this.radioButtonPresent.TabIndex = 2;
            this.radioButtonPresent.TabStop = true;
            this.radioButtonPresent.Text = "출석";
            this.radioButtonPresent.UseVisualStyleBackColor = true;

            // 
            // radioButtonLate
            // 
            this.radioButtonLate.AutoSize = true;
            this.radioButtonLate.Location = new System.Drawing.Point(240, 120);
            this.radioButtonLate.Name = "radioButtonLate";
            this.radioButtonLate.Size = new System.Drawing.Size(65, 20);
            this.radioButtonLate.TabIndex = 3;
            this.radioButtonLate.TabStop = true;
            this.radioButtonLate.Text = "지각";
            this.radioButtonLate.UseVisualStyleBackColor = true;

            // 
            // radioButtonAbsent
            // 
            this.radioButtonAbsent.AutoSize = true;
            this.radioButtonAbsent.Location = new System.Drawing.Point(240, 150);
            this.radioButtonAbsent.Name = "radioButtonAbsent";
            this.radioButtonAbsent.Size = new System.Drawing.Size(65, 20);
            this.radioButtonAbsent.TabIndex = 4;
            this.radioButtonAbsent.TabStop = true;
            this.radioButtonAbsent.Text = "결석";
            this.radioButtonAbsent.UseVisualStyleBackColor = true;

            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(240, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "저장";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(20, 20);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(70, 16);
            this.labelStudent.TabIndex = 6;
            this.labelStudent.Text = "학생 목록";

            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(240, 20);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(70, 16);
            this.labelCourse.TabIndex = 7;
            this.labelCourse.Text = "수강 과목";

            // 
            // labelAttendanceStatus
            // 
            this.labelAttendanceStatus.AutoSize = true;
            this.labelAttendanceStatus.Location = new System.Drawing.Point(240, 70);
            this.labelAttendanceStatus.Name = "labelAttendanceStatus";
            this.labelAttendanceStatus.Size = new System.Drawing.Size(100, 16);
            this.labelAttendanceStatus.TabIndex = 8;
            this.labelAttendanceStatus.Text = "출석 상태 선택";

            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(20, 220);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDate.TabIndex = 9;
            // 날짜 제한 설정
            this.dateTimePickerDate.MinDate = new DateTime(2024, 9, 1);
            this.dateTimePickerDate.MaxDate = new DateTime(2024, 12, 31);

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 250);
            this.Controls.Add(this.labelAttendanceStatus);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioButtonAbsent);
            this.Controls.Add(this.radioButtonLate);
            this.Controls.Add(this.radioButtonPresent);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.dateTimePickerDate);
            this.Name = "Form2";
            this.Text = "출석 관리";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
