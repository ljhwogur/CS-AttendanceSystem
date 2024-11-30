namespace AttendanceSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.TextBox textBoxMajor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonStudentStatistics; // 학생 통계 버튼 추가
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelMajor;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonStudentStatistics = new System.Windows.Forms.Button();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelMajor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(760, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(100, 262);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(150, 25);
            this.textBoxStudentID.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 291);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 25);
            this.textBoxName.TabIndex = 2;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(100, 319);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(150, 25);
            this.dateTimePickerDOB.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(100, 347);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(150, 25);
            this.textBoxPhoneNumber.TabIndex = 4;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxGrade.Location = new System.Drawing.Point(100, 375);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(150, 23);
            this.comboBoxGrade.TabIndex = 5;
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.Location = new System.Drawing.Point(100, 403);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.Size = new System.Drawing.Size(150, 25);
            this.textBoxMajor.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(300, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(300, 300);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "수정";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(300, 338);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Location = new System.Drawing.Point(300, 375);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(100, 28);
            this.buttonAttendance.TabIndex = 10;
            this.buttonAttendance.Text = "출석관리";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(300, 412);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(100, 28);
            this.buttonStatistics.TabIndex = 11;
            this.buttonStatistics.Text = "출석 통계";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonStudentStatistics
            // 
            this.buttonStudentStatistics.Location = new System.Drawing.Point(479, 300);
            this.buttonStudentStatistics.Name = "buttonStudentStatistics";
            this.buttonStudentStatistics.Size = new System.Drawing.Size(200, 28);
            this.buttonStudentStatistics.TabIndex = 12;
            this.buttonStudentStatistics.Text = "학생 과목 별 주/월간 통계";
            this.buttonStudentStatistics.UseVisualStyleBackColor = true;
            this.buttonStudentStatistics.Click += new System.EventHandler(this.buttonStudentStatistics_Click);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(20, 262);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(37, 15);
            this.labelStudentID.TabIndex = 12;
            this.labelStudentID.Text = "학번";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 291);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 15);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "이름";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(20, 319);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(67, 15);
            this.labelDOB.TabIndex = 14;
            this.labelDOB.Text = "생년월일";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(20, 347);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(67, 15);
            this.labelPhoneNumber.TabIndex = 15;
            this.labelPhoneNumber.Text = "전화번호";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(20, 375);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(37, 15);
            this.labelGrade.TabIndex = 16;
            this.labelGrade.Text = "학년";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Location = new System.Drawing.Point(20, 403);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(37, 15);
            this.labelMajor.TabIndex = 17;
            this.labelMajor.Text = "전공";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.labelMajor);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAttendance);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonStudentStatistics);
            this.Name = "Form1";
            this.Text = "학생 출석 관리 시스템";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
