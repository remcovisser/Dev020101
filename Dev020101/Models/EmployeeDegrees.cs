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
        public int employeeDegrees_id;
        public string bsn;
        public int degree_id;

        // Relations
        public Degrees degree()
        {
            return new Degrees().hasOne(this, "degree_id", "degree_id");
        }
    }
}
