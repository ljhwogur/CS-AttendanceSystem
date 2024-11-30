using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace AttendanceSystem
{
    public partial class Form4 : Form
    {
        private string connectionString = "User Id=hong1;Password=1111;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL =TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA= (SERVER = DEDICATED) (SERVICE_NAME = xe)) );";

        public Form4()
        {
            InitializeComponent();
            ConfigureListViewHeaders();
            LoadMonthlyStatistics();
            LoadCourseProfessors();
        }

        private void ConfigureListViewHeaders()
        {
            listViewMonthlyStatistics.Columns.Add("학생명", 100);
            listViewMonthlyStatistics.Columns.Add("과목명", 150);
            listViewMonthlyStatistics.Columns.Add("월", 100);
            listViewMonthlyStatistics.Columns.Add("출석", 100);
            listViewMonthlyStatistics.Columns.Add("지각", 100);
            listViewMonthlyStatistics.Columns.Add("결석", 100);

            listViewCourseProfessors.Columns.Add("과목명", 150);
            listViewCourseProfessors.Columns.Add("교수명", 150);
            listViewCourseProfessors.Columns.Add("학과", 150);
        }

        private void LoadMonthlyStatistics()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            S.Name AS 학생명,
                            C.CourseName AS 과목명,
                            TO_CHAR(A.AttendanceDate, 'YYYY-MM') AS 월,
                            COUNT(CASE WHEN A.Status = '출석' THEN 1 END) AS 출석,
                            COUNT(CASE WHEN A.Status = '지각' THEN 1 END) AS 지각,
                            COUNT(CASE WHEN A.Status = '결석' THEN 1 END) AS 결석
                        FROM 
                            Attendance A
                        JOIN 
                            Students S ON A.StudentID = S.StudentID
                        JOIN 
                            Courses C ON A.CourseID = C.CourseID
                        WHERE 
                            A.AttendanceDate BETWEEN TO_DATE('2024-09-01', 'YYYY-MM-DD') 
                            AND TO_DATE('2024-12-31', 'YYYY-MM-DD')
                        GROUP BY 
                            S.Name, C.CourseName, TO_CHAR(A.AttendanceDate, 'YYYY-MM')
                        ORDER BY 
                            S.Name, C.CourseName, 월";

                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listViewMonthlyStatistics.Items.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["학생명"].ToString());
                        item.SubItems.Add(row["과목명"].ToString());
                        item.SubItems.Add(row["월"].ToString());
                        item.SubItems.Add(row["출석"].ToString());
                        item.SubItems.Add(row["지각"].ToString());
                        item.SubItems.Add(row["결석"].ToString());
                        listViewMonthlyStatistics.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        private void LoadCourseProfessors()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            C.CourseName AS 과목명,
                            P.Name AS 교수명,
                            P.Department AS 학과
                        FROM 
                            CourseProfessors CP
                        JOIN 
                            Courses C ON CP.CourseID = C.CourseID
                        JOIN 
                            Professors P ON CP.ProfessorID = P.ProfessorID
                        ORDER BY C.CourseName";

                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listViewCourseProfessors.Items.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["과목명"].ToString());
                        item.SubItems.Add(row["교수명"].ToString());
                        item.SubItems.Add(row["학과"].ToString());
                        listViewCourseProfessors.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            if (listViewMonthlyStatistics.SelectedItems.Count == 0)
            {
                MessageBox.Show("학생을 선택하세요.");
                return;
            }

            string selectedStudentName = listViewMonthlyStatistics.SelectedItems[0].SubItems[0].Text;

            try
            {
                DataTable monthlyStatistics = GetStudentMonthlyStatistics(selectedStudentName);
                DataTable courseProfessors = GetStudentCourseProfessors(selectedStudentName);

                string filePath = SaveReportToFile(selectedStudentName, monthlyStatistics, courseProfessors);
                MessageBox.Show($"보고서가 저장되었습니다: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"보고서 생성 중 오류 발생: {ex.Message}");
            }
        }

        private DataTable GetStudentMonthlyStatistics(string studentName)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        C.CourseName AS 과목명,
                        TO_CHAR(A.AttendanceDate, 'YYYY-MM') AS 월,
                        COUNT(CASE WHEN A.Status = '출석' THEN 1 END) AS 출석,
                        COUNT(CASE WHEN A.Status = '지각' THEN 1 END) AS 지각,
                        COUNT(CASE WHEN A.Status = '결석' THEN 1 END) AS 결석
                    FROM 
                        Attendance A
                    JOIN 
                        Students S ON A.StudentID = S.StudentID
                    JOIN 
                        Courses C ON A.CourseID = C.CourseID
                    WHERE 
                        S.Name = :StudentName
                    GROUP BY 
                        C.CourseName, TO_CHAR(A.AttendanceDate, 'YYYY-MM')
                    ORDER BY 
                        C.CourseName, 월";

                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add(new OracleParameter("StudentName", studentName));
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private DataTable GetStudentCourseProfessors(string studentName)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = @"
                    SELECT DISTINCT
                        C.CourseName AS 과목명,
                        P.Name AS 교수명,
                        P.Department AS 학과
                    FROM 
                        Attendance A
                    JOIN 
                        Students S ON A.StudentID = S.StudentID
                    JOIN 
                        Courses C ON A.CourseID = C.CourseID
                    JOIN 
                        CourseProfessors CP ON C.CourseID = CP.CourseID
                    JOIN 
                        Professors P ON CP.ProfessorID = P.ProfessorID
                    WHERE 
                        S.Name = :StudentName";

                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add(new OracleParameter("StudentName", studentName));
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private string SaveReportToFile(string studentName, DataTable monthlyStatistics, DataTable courseProfessors)
        {
            string filePath = $"{studentName}_통계보고서.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"학생 이름: {studentName}");
                writer.WriteLine("\n[월간 통계]");
                writer.WriteLine("------------------------------------------------------");

                foreach (DataRow row in monthlyStatistics.Rows)
                {
                    writer.WriteLine($"과목: {row["과목명"]}, 월: {row["월"]}, 출석: {row["출석"]}, 지각: {row["지각"]}, 결석: {row["결석"]}");
                }

                writer.WriteLine("\n[과목별 담당 교수]");
                writer.WriteLine("------------------------------------------------------");

                foreach (DataRow row in courseProfessors.Rows)
                {
                    writer.WriteLine($"과목: {row["과목명"]}, 교수: {row["교수명"]}, 학과: {row["학과"]}");
                }
            }

            return filePath;
        }

        private void buttonOpenForm5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
