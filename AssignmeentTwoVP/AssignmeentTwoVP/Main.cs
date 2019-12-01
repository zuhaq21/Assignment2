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
    public partial class Main : Form
    {
        String id;
        public Main()       
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            addStudentPanel.Visible = true;  //-----------------------------------------------------
            id = obj.setId();
            Idlabel.Text = id;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStudentPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deletePanel.Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deletePanel.Visible = true;
        }

        private void markAttendenceButton_Click(object sender, EventArgs e)
        {
            MarkAttendence obj = new MarkAttendence();
            obj.Show();
            this.Hide();
        }

        private void viewAttendenceButton_Click(object sender, EventArgs e)
        {
            ViewAttendence obj = new ViewAttendence();
            obj.Show();
            this.Hide();
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            String name = NameTextBox.Text;
            String university = universitytextBox.Text;
            String cgpa = CGPAtextBox.Text;
            String semester = semestercomboBox.Text;
            String department = DepartmentcomboBox.Text;
            obj.addStudent(name, semester, cgpa, department, university, id);
            MessageBox.Show("Student data saved successfully");
            NameTextBox.Text = "";
            universitytextBox.Text = "";
            CGPAtextBox.Text = "";
            semestercomboBox.ResetText();
            DepartmentcomboBox.ResetText();
            addStudentPanel.Visible = false;
        }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            int check;
            String id=deleteIdTextBox.Text;
            check = obj.deleteStudent(id);
            if (check > 0)
            {
                MessageBox.Show("Record Deleted");
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            deletePanel.Visible = false;
        }

        private void searchByIdButton_Click(object sender, EventArgs e)
        {
            searchByIdPanel.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String[] data = new String[6];
            String name, semester, department, cgpa, university;
            Student obj = new Student();
            String id = searchByIdTextBox.Text;
            data = obj.searchById(id);
            if (data != null)
            {
                displayByIdListBox.Items.Add("ID is   :      " + data[0]);
                displayByIdListBox.Items.Add("Name is :      " + data[1]);
                displayByIdListBox.Items.Add("Semester is:   " + data[2]);
                displayByIdListBox.Items.Add("CGPA is :      " + data[3]);
                displayByIdListBox.Items.Add("Department is: " + data[4]);
                displayByIdListBox.Items.Add("University is: " + data[5]);
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }

        }

        private void displayAllStudentsButton_Click(object sender, EventArgs e)
        {
            DisplayStudents obj = new DisplayStudents();
            obj.Show();
            this.Hide();
            
        }

        private void searchNameButton_Click(object sender, EventArgs e)
        {
            int number = 0;
            String name = searchByNameTextBox.Text;
            String[] arrText;
            arrText = File.ReadAllLines("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt");
            for (int i = 1; i < arrText.Length; i=i+7)
            {
                if (arrText[i] == Name)
                {
                    number++;
                    searchByNameListBox.Items.Add("/t Student " + number);
                    searchByNameListBox.Items.Add("ID is :         " + arrText[i - 1]);
                    searchByNameListBox.Items.Add("Name is :       " + arrText[i]);
                    searchByNameListBox.Items.Add("Semester is :   " + arrText[i + 1]);
                    searchByNameListBox.Items.Add("Department is : " + arrText[i + 3]);
                }
                else
                {
                    continue;
                }
                if (number==0)
                {
                    MessageBox.Show("No record found");
                }
            }
        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            searchByNamePanel.Visible = true;
        }

        private void topThreeButton_Click(object sender, EventArgs e)
        {
            TopThree obj = new TopThree();
            obj.Show();
            this.Hide();
        }
    }
}
