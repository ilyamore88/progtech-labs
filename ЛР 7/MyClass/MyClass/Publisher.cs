using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Publisher
    {
        struct LicenseNumber
        {
            public int licenseNumber;
            public DateTime data;

            public override string ToString()
            {
                string bs = String.Format("Лицензия N-{0} от {1} г.", licenseNumber, data.Year);
                return bs;
            }
        }

        public string Name { get; set; }
        public string EmailAdress { get; set; }
        private LicenseNumber LinNumber;

        public Publisher(string name, string emailAdress, int lnumber, DateTime data)
        {
            this.Name = name;
            this.EmailAdress = emailAdress;
            this.LinNumber.licenseNumber = lnumber;
            this.LinNumber.data = data;
        }

        public override string ToString()
        {
            string bs = String.Format(": {0}, электронный адрес: {1}, {2}", this.Name, this.EmailAdress, this.LinNumber);
            return bs;
        }
    }
}
