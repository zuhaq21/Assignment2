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
    public partial class TopThree : Form
    {
        public TopThree()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.Show();
        }

        private void TopThree_Load(object sender, EventArgs e)
        {
            double first, second, third, max;
            String firstName, secondName, thirdName, name;
            String firstId, secondId, thirdId, id;
            String[] arrText;
            arrText = File.ReadAllLines("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt");
            first = second = third = max = 0;
            firstName = secondName = thirdName= name="";
            firstId = secondId = thirdId = id = "";
            for (int i = 3; i < arrText.Length; i = i + 7)
            {
                max = Convert.ToDouble(arrText[i]);
                if (max>first)
                {
                    third = second;
                    second = first;
                    first = max;
                    firstName = arrText[i - 2];
                    firstId = arrText[i - 3];
                }
                else if (max > second)
                {
                    third = second;
                    second = max;
                    secondName = arrText[i - 2];
                    secondId = arrText[i - 3];
                } 
                else if (max > third)
                {
                    third = max;
                    thirdId = arrText[i - 3];
                    thirdName = arrText[i - 2];
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("CGPA");
            dt.Rows.Add(new object[] { firstId, firstName, first });
            dt.Rows.Add(new object[] { secondId, secondName, second });
            dt.Rows.Add(new object[] { thirdId, thirdName, third });
            dataGridView1.DataSource = dt;
        }
    }
}
