using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Student : Person
    {
        private List<int> Grades = new List<int>();
        public string Faculty { get; set; }
        public string Group { get; set; }

        public Student(int id, string lastname, string firstname, DateTime birthdate, string username, string password, string faculty, string group) : base(id, lastname, firstname, birthdate, username, password, Permissions.student)
        {
            Faculty = faculty;
            Group = group;
        }

        public void SetGrades(List<int> grades)
        {
            this.Grades = grades;
        }

        public void AddGrade(int grade)
        {
            this.Grades.Add(grade);
        }

        public void DeleteGrades()
        {
            this.Grades.Clear();
        }

        public IReadOnlyCollection<int> GetGrades()
        {
            return this.Grades.AsReadOnly();
        }

        public bool IsCool()
        {
            if (this.Grades.Contains(2) || this.Grades.Contains(3) || this.Grades.Contains(4) || this.Grades.Contains(5))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            string gradesS = "";
            foreach (int grade in this.Grades)
            {
                gradesS += grade.ToString() + " ";
            }
            string bs = String.Format("Студент: \n" +
                "\tИмя: {0} {1}\n" +
                "\tДата рождения: {2}\n" +
                "\tID: {3}\n" +
                "\tФакультет: {4}\n" +
                "\tГруппа: {5}\n" +
                "\tОценки: {6}\n", this.Firstname, this.Lastname, this.Birthdate.ToString("dd.MM.yyyy"), this.Id, this.Faculty, this.Group, (gradesS == "" ? "отсутствуют" : gradesS));
            return bs;
        }

        public override float GetSalary()
        {
            return 0;
        }
    }
}
