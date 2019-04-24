using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Manager : Person
    {
        public string Faculty { get; set; }
        public string Post { get; set; }

        public Manager(int id, string lastname, string firstname, DateTime birthdate, string username, string password, string faculty, string post) : base(id, lastname, firstname, birthdate, username, password, Permissions.manager)
        {
            Faculty = faculty;
            Post = post;
        }

        override public float GetSalary()
        {
            return 45000;
        }
    }
}
