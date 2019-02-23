using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    abstract class Person
    {
        public enum Permissions { admin, student, teacher, manager }

        public int Id { get; set; }
        public string Lastname { get; }
        public string Firstname { get; }
        public DateTime Birthdate { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int WorkExperience { get; set; }
        public Permissions CurrentPermissions { get; set; }

        protected Person() { }

        public Person(int id, string lastname, string firstname, DateTime birthdate, string username, string password, int workExperience, Permissions currentPermissions)
        {
            Id = id;
            Lastname = lastname;
            Firstname = firstname;
            Birthdate = birthdate;
            Username = username;
            Password = password;
            WorkExperience = workExperience;
            CurrentPermissions = currentPermissions;
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - this.Birthdate.Year;
            if (this.Birthdate > today.AddYears(-age)) age--;
            return age;
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

        public void Print()
        {
            Console.WriteLine(this);
        }

        public void ChangePassword(string newPassword)
        {
            this.Password = newPassword;
        }
    }
}
