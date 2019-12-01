using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AssignmeentTwoVP
{
    class Student
    {
        public void addStudent(String name, String semester, String cgpa, String department, String university, String id)
        {
            using (StreamWriter writetext = File.AppendText("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt"))
            {
                String attendence = "Absent";
                writetext.WriteLine(id);
                writetext.WriteLine(name);
                writetext.WriteLine(semester);
                writetext.WriteLine(cgpa);
                writetext.WriteLine(department);
                writetext.WriteLine(university);
                writetext.WriteLine(attendence);
            }
        }
        public string setId()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            var FormNumber = BitConverter.ToUInt32(buffer, 0) ^ BitConverter.ToUInt32(buffer, 4) ^ BitConverter.ToUInt32(buffer, 8) ^ BitConverter.ToUInt32(buffer, 12);
            return FormNumber.ToString("X");
        }
        public int deleteStudent(String id)
        {
            String[] arrText;
            List<String> newText = new List<String>();
            int found = 0;
            arrText = File.ReadAllLines("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt");
            for (int i = 0; i < arrText.Length; i = i + 7)
            {
                if (arrText[i] == id)
                {
                    found++;
                    continue;
                }
                else
                {
                    newText.Add(arrText[i]);
                    newText.Add(arrText[i + 1]);
                    newText.Add(arrText[i + 2]);
                    newText.Add(arrText[i + 3]);
                    newText.Add(arrText[i + 4]);
                    newText.Add(arrText[i + 5]);
                    newText.Add(arrText[i + 6]);
                }
                //return found;
                using (StreamWriter writetext = new StreamWriter("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt"))
                {
                    for (int j = 0; j < arrText.Length - 7; j++)
                    {
                        writetext.WriteLine(newText[j]);
                    }
                }
            }
            return found;
        }
        public String[] searchById(String id)
        {
            int j=0;
            String[] data = new String[6];
            string[] arrText;
            int foundById = 0;
            string[] studentData = new string[6];
            arrText = File.ReadAllLines("D:/Uni/BSE-5/VP/Assignments/AssignmentTwoData.txt");
            for (int i = 0; i < arrText.Length; i = i + 7)
            {
                if (arrText[i] == id)
                {
                    data[j] = arrText[i];
                    data[j + 1] = " " + arrText[i + 1];
                    data[j + 2] = " " + arrText[i + 2];
                    data[j + 3] = " " + arrText[i + 3];
                    data[j + 4] = " " + arrText[i + 4];
                    data[j + 5] = " " + arrText[i + 5];
                   // Main obj = new Main();
                    foundById++;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (foundById > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

    }
}
