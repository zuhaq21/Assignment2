using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AssignmeentTwoVP
{
    public partial class DisplayStudents : Form
    {
        public DisplayStudents()
        {
            InitializeComponent();
        }

        private void DisplayStudents_Load(object sender, EventArgs e)
        {
            String[] arrText;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Semester");
            dt.Columns.Add("Cgpa");
            dt.Columns.Add("Department");
            dt.Columns.Add("University");
            arrText = File.ReadAllLines("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt");
            for (int i = 0; i < arrText.Length; i=i+7)
            {
                String id = arrText[i];
                String name = arrText[i + 1];
                String semester = arrText[i + 2];
                String cgpa = arrText[i + 3];
                String department = arrText[i + 4];
                String university = arrText[i + 5];
                dt.Rows.Add(new object[] { id, name, semester, cgpa, department, university });
            }
            displayStudentsdataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            obj.Show();
            this.Hide();
        }
    }
}
