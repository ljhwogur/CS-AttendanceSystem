using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace AttendanceSystem
{
    public partial class Form2 : Form
    {
        private string connectionString = "User Id=hong1;Password=1111;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL =TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA= (SERVER = DEDICATED) (SERVICE_NAME = xe)) );";

        public Form2()
        {
            InitializeComponent();
            LoadCourses(); // 과목 데이터를 로드하는 메서드 호출
            LoadStudents(); // 학생 데이터를 로드하는 메서드 호출
        }

        // 과목 데이터를 ComboBox에 로드하는 메서드
        private void LoadCourses()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CourseID, CourseName FROM Courses";
                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxCourses.DataSource = dataTable;
                    comboBoxCourses.DisplayMember = "CourseName";
                    comboBoxCourses.ValueMember = "CourseID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        // 학생 데이터를 ListBox에 로드하는 메서드
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
                    listBoxStudents.DisplayMember = "Name";
                    listBoxStudents.ValueMember = "StudentID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        // 새로운 AttendanceID 생성
        private int GetNewAttendanceID(OracleConnection conn)
        {
            string query = "SELECT NVL(MAX(AttendanceID), 0) + 1 FROM Attendance";
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // 출석 정보 저장
        private void SaveAttendance()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 새로운 AttendanceID 생성
                    int newAttendanceID = GetNewAttendanceID(conn);

                    string query = "INSERT INTO Attendance (AttendanceID, StudentID, CourseID, AttendanceDate, Status) VALUES (:AttendanceID, :StudentID, :CourseID, :AttendanceDate, :Status)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("AttendanceID", newAttendanceID)); // 생성된 AttendanceID
                        cmd.Parameters.Add(new OracleParameter("StudentID", listBoxStudents.SelectedValue.ToString()));
                        cmd.Parameters.Add(new OracleParameter("CourseID", comboBoxCourses.SelectedValue.ToString()));
                        cmd.Parameters.Add(new OracleParameter("AttendanceDate", dateTimePickerDate.Value));

                        // 출석 상태 선택
                        string status = "";
                        if (radioButtonPresent.Checked) status = "출석";
                        else if (radioButtonLate.Checked) status = "지각";
                        else if (radioButtonAbsent.Checked) status = "결석";

                        cmd.Parameters.Add(new OracleParameter("Status", status));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("출석 정보가 저장되었습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveAttendance();
        }
    }
}