using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;


namespace Dev020101.Models
{
    public class EmployeeDegrees : MySqlModel<EmployeeDegrees>
    {
        public int degree_id;
        public string bsn;
    }
}
