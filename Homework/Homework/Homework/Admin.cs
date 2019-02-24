using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Admin : Person
    {
        public string Laboratory { get; }

        public Admin(int id, string lastname, string firstname, DateTime birthdate, string username, string password, string laboratory) : base(id, lastname, firstname, birthdate, username, password, Permissions.admin)
        {
            this.Laboratory = laboratory;
        }

        public override string ToString()
        {
            string bs = String.Format("Администратор: \n" +
                "\tИмя: {0} {1}\n" +
                "\tДата рождения: {2}\n" +
                "\tID: {3}\n" +
                "\tМесто работы: {4}\n", this.Firstname, this.Lastname, this.Birthdate.ToString("dd.MM.yyyy"), this.Id, this.Laboratory);
            return bs;
        }
    }
}
