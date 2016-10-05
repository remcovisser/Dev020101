using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class Employees : MySqlModel<Employees>
    {
        public int bsn;
        public string firstName;
        public string lastName;

        // Helper methods
        public string fullname()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
