using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Teacher : Person
    {
        public string Faculty { get; set; }
        public string Post { get; set; }
        public int WorkExperience { get; set; }

        public Teacher(int id, string lastname, string firstname, DateTime birthdate, string username, string password, int workExperience, string faculty, string post) : base(id, lastname, firstname, birthdate, username, password, Permissions.teacher)
        {
            WorkExperience = workExperience;
            Faculty = faculty;
            Post = post;
        }

        public bool AddWorkExperience(int workYears)
        {
            if (workYears > 0)
            {
                this.WorkExperience += workYears;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool RemoveWorkExperience(int workYears)
        {
            if (workYears <= this.WorkExperience && workYears > 0)
            {
                this.WorkExperience -= workYears;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string bs = String.Format("Преподаватель: \n" +
                "\tИмя: {0} {1}\n" +
                "\tДата рождения: {2}\n" +
                "\tID: {3}\n" +
                "\tФакультет: {4}\n" +
                "\tДолжность: {5}\n", this.Firstname, this.Lastname, this.Birthdate.ToString("dd.MM.yyyy"), this.Id, this.Faculty, this.Post);
            return bs;
        }

        override public float GetSalary()
        {
            return this.WorkExperience * 15000;
        }
    }
}
