using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace AttendanceSystem
{
    public partial class Form3 : Form
    {
        private string connectionString = "User Id=hong1;Password=1111;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL =TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA= (SERVER = DEDICATED) (SERVICE_NAME = xe)) );";

        public Form3()
        {
            InitializeComponent();
            LoadStudents(); // 학생 목록 로드
        }

        // 학생 목록 로드
        private void LoadStudents()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT StudentID, Name FROM Students";
                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listBoxStudents.DataSource = dataTable;
                    listBoxStudents.DisplayMember = "Name"; // 학생 이름 표시
                    listBoxStudents.ValueMember = "StudentID"; // 학생 ID 값
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        // 학생 선택 시 해당 학생의 출석 통계 조회
        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedValue == null) return;

            string selectedStudentID = listBoxStudents.SelectedValue.ToString();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 출석 일수
                    string presentQuery = "SELECT COUNT(*) FROM Attendance WHERE StudentID = :StudentID AND Status = '출석'";
                    OracleCommand presentCmd = new OracleCommand(presentQuery, conn);
                    presentCmd.Parameters.Add(new OracleParameter("StudentID", selectedStudentID));
                    int totalPresent = Convert.ToInt32(presentCmd.ExecuteScalar());

                    // 지각 일수
                    string lateQuery = "SELECT COUNT(*) FROM Attendance WHERE StudentID = :StudentID AND Status = '지각'";
                    OracleCommand lateCmd = new OracleCommand(lateQuery, conn);
                    lateCmd.Parameters.Add(new OracleParameter("StudentID", selectedStudentID));
                    int totalLate = Convert.ToInt32(lateCmd.ExecuteScalar());

                    // 결석 일수
                    string absentQuery = "SELECT COUNT(*) FROM Attendance WHERE StudentID = :StudentID AND Status = '결석'";
                    OracleCommand absentCmd = new OracleCommand(absentQuery, conn);
                    absentCmd.Parameters.Add(new OracleParameter("StudentID", selectedStudentID));
                    int totalAbsent = Convert.ToInt32(absentCmd.ExecuteScalar());

                    // 전체 일수
                    int totalDays = totalPresent + totalLate + totalAbsent;
                    double attendanceRate = totalDays > 0 ? ((totalPresent + totalLate) / (double)totalDays) * 100 : 0;

                    // 통계 출력
                    labelTotalPresent.Text = "총 출석 일수: " + totalPresent;
                    labelTotalLates.Text = "총 지각 일수: " + totalLate;
                    labelTotalAbsences.Text = "총 결석 일수: " + totalAbsent;
                    labelAttendanceRate.Text = "출석률: " + attendanceRate.ToString("0.00") + "%";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }
    }
}
