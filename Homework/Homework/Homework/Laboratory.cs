using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Laboratory
    {
        public string LaboratoryName { get; set; }
        private Admin Admin = null;
        private List<Student> Students = new List<Student>();

        public Laboratory(string laboratoryName)
        {
            LaboratoryName = laboratoryName;
            Admin = new Admin(264882, "Мороз", "Илья", new DateTime(2001, 08, 08), "admin", "admin", LaboratoryName);
        }

        public Admin GetAdmin()
        {
            return this.Admin;
        }

        public List<Student> GetStudents()
        {
            return this.Students;
        }

        public void AddStudent(Student Student)
        {
            this.Students.Add(Student);
        }

        public List<Person> GetPeople()
        {
            List<Person> People = new List<Person>();
            People.Add(this.Admin);
            People.AddRange(this.Students);
            return People;
        }   //Не забывать добавлять новые списки

        public void PrintInfoAboutLaboratory()
        {
            Console.Clear();
            Console.WriteLine("--- {0} ---", this.LaboratoryName);
            Console.WriteLine("Администратор: ");
            Console.WriteLine("\t{0} {1}, ID: {2}", this.Admin.Lastname, this.Admin.Firstname, this.Admin.Id);
            Console.WriteLine("Студенты: ");
            foreach (Student student in Students)
            {
                Console.WriteLine("\t{0} {1}, ID: {2}, Группа: {3}", student.Lastname, student.Firstname, student.Id, student.Group);
            }
            Console.ReadKey();
        }
    }
}
