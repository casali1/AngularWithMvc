using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularWithMvc.Models;

namespace AngularWithMvc.Service
{
    public class ListOfData
    {
        int hold = 1;
        Data data = new Data();
        List<Student> holdData = new List<Student>();

        public List<Student> GetStudents()
        {
            if (hold == 1)
            {
                hold++;
                holdData = data.GetData();
                return holdData;
            }
            else
                return holdData;
        }

        public Student GetStudent(int ID)
        {
            return holdData.FirstOrDefault(x => x.Id == ID);
        }

        public void AddStudent(Student stu)
        {
            holdData.Add(stu);
        }

        public void UpdateStudent(Student stu)
        {
            foreach(var student in holdData)
            {
                if(student.Id == stu.Id)
                {
                    holdData.Remove(student);
                    holdData.Add(stu);
                    break;
                }
            }
        }

        public void DeleteFromList(int ID)
        {
            foreach (var student in holdData)
            {
                if (student.Id == ID)
                {
                    holdData.Remove(student);
                    break;
                }
            }
        }
    }
}