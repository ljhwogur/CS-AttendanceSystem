using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client; // Oracle.ManagedDataAccess.Client도 가능

namespace AttendanceSystem
{
    public partial class Form1 : Form
    {
        private string connectionString = "User Id=hong1;Password=1111;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL =TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA= (SERVER = DEDICATED) (SERVICE_NAME = xe)) );";

        public Form1()
        {
            InitializeComponent();
            LoadStudentData();
            dataGridView1.CellClick += DataGridView1_CellClick; // CellClick 이벤트 추가
        }

        // 데이터 불러오기
        private void LoadStudentData()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT StudentID, Name, DateOfBirth, PhoneNumber, Grade, Major FROM Students";

                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        // DataGridView 클릭 이벤트
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 유효한 행을 클릭한 경우
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxStudentID.Text = row.Cells["StudentID"].Value.ToString();
                textBoxName.Text = row.Cells["Name"].Value.ToString();
                dateTimePickerDOB.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                textBoxPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                comboBoxGrade.SelectedItem = row.Cells["Grade"].Value.ToString();
                textBoxMajor.Text = row.Cells["Major"].Value.ToString();
            }
        }

        // 추가 버튼 클릭 이벤트
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Students (StudentID, Name, DateOfBirth, PhoneNumber, Grade, Major) " +
                                   "VALUES (:StudentID, :Name, :DateOfBirth, :PhoneNumber, :Grade, :Major)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("StudentID", textBoxStudentID.Text));
                        cmd.Parameters.Add(new OracleParameter("Name", textBoxName.Text));
                        cmd.Parameters.Add(new OracleParameter("DateOfBirth", dateTimePickerDOB.Value));
                        cmd.Parameters.Add(new OracleParameter("PhoneNumber", textBoxPhoneNumber.Text));
                        cmd.Parameters.Add(new OracleParameter("Grade", comboBoxGrade.SelectedItem.ToString()));
                        cmd.Parameters.Add(new OracleParameter("Major", textBoxMajor.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("학생 정보가 추가되었습니다.");
                    }

                    LoadStudentData(); // 데이터 다시 로드
                    ClearTextFields(); // 텍스트 필드 비우기
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        // 수정 버튼 클릭 이벤트
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("수정할 학생을 선택하세요.");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Students SET Name = :Name, DateOfBirth = :DateOfBirth, PhoneNumber = :PhoneNumber, " +
                                   "Grade = :Grade, Major = :Major WHERE StudentID = :StudentID";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Name", textBoxName.Text));
                        cmd.Parameters.Add(new OracleParameter("DateOfBirth", dateTimePickerDOB.Value));
                        cmd.Parameters.Add(new OracleParameter("PhoneNumber", textBoxPhoneNumber.Text));
                        cmd.Parameters.Add(new OracleParameter("Grade", comboBoxGrade.SelectedItem.ToString()));
                        cmd.Parameters.Add(new OracleParameter("Major", textBoxMajor.Text));
                        cmd.Parameters.Add(new OracleParameter("StudentID", textBoxStudentID.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("학생 정보가 수정되었습니다.");
                    }

                    LoadStudentData(); // 데이터 다시 로드
                    ClearTextFields(); // 텍스트 필드 비우기
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        // 삭제 버튼 클릭 이벤트
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStudentID.Text))
            {
                MessageBox.Show("삭제할 학생의 학번을 입력하세요.");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 자식 테이블 데이터 삭제
                    string deleteAttendanceQuery = "DELETE FROM Attendance WHERE StudentID = :StudentID";
                    string deleteStudentCoursesQuery = "DELETE FROM StudentCourses WHERE StudentID = :StudentID";
                    string deleteStudentQuery = "DELETE FROM Students WHERE StudentID = :StudentID";

                    using (OracleCommand cmd1 = new OracleCommand(deleteAttendanceQuery, conn))
                    using (OracleCommand cmd2 = new OracleCommand(deleteStudentCoursesQuery, conn))
                    using (OracleCommand cmd3 = new OracleCommand(deleteStudentQuery, conn))
                    {
                        cmd1.Parameters.Add(new OracleParameter("StudentID", textBoxStudentID.Text));
                        cmd2.Parameters.Add(new OracleParameter("StudentID", textBoxStudentID.Text));
                        cmd3.Parameters.Add(new OracleParameter("StudentID", textBoxStudentID.Text));

                        // 자식 테이블 데이터 삭제
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        // 부모 테이블 데이터 삭제
                        cmd3.ExecuteNonQuery();

                        MessageBox.Show("학생 정보가 삭제되었습니다.");
                    }

                    LoadStudentData(); // 데이터 다시 로드
                    ClearTextFields(); // 텍스트 필드 비우기
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }


        // 텍스트 필드 비우기 메서드
        private void ClearTextFields()
        {
            textBoxStudentID.Clear();
            textBoxName.Clear();
            dateTimePickerDOB.Value = DateTime.Today;
            textBoxPhoneNumber.Clear();
            comboBoxGrade.SelectedIndex = -1;
            textBoxMajor.Clear();
        }

        // 출석관리 버튼 클릭 이벤트
        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // Form2를 열기
        }

        // 출석 통계 버튼 클릭 이벤트
        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); // Form3를 열기
        }

        // "학생 과목 별 주/월간 통계" 버튼 클릭 이벤트
        private void buttonStudentStatistics_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show(); // Form4를 표시
        }
    }
}
