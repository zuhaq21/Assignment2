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
    public partial class ViewAttendence : Form
    {
        public ViewAttendence()
        {
            InitializeComponent();
        }

        private void ViewAttendence_Load(object sender, EventArgs e)
        {
            String[] arrText;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Attendence");
            arrText = File.ReadAllLines("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt");
            for (int i = 0; i < arrText.Length; i=i+7)
            {
                String id = arrText[i];
                String name = arrText[i + 1];
                String attendence = arrText[i + 6];
                dt.Rows.Add(new object[] { id, name, attendence });
            }
            viewAttendenceDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            obj.Show();
            this.Hide();
        }
    }
}
