using System;
using System.IO;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LoadSavedReports();
        }

        private void LoadSavedReports()
        {
            listViewReports.Items.Clear();

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*_통계보고서.txt");
            foreach (var file in files)
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(file));
                item.SubItems.Add(new FileInfo(file).LastWriteTime.ToString());
                listViewReports.Items.Add(item);
            }
        }

        private void buttonViewReport_Click(object sender, EventArgs e)
        {
            if (listViewReports.SelectedItems.Count == 0)
            {
                MessageBox.Show("보고서를 선택하세요.");
                return;
            }

            string fileName = listViewReports.SelectedItems[0].Text;
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            string reportContent = File.ReadAllText(filePath);
            MessageBox.Show(reportContent, "보고서 내용", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
