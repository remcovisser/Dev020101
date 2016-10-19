using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class EmployeePositions : MySqlModel<EmployeePositions>
    {
        public int employeePositions_id;
        public string bsn;
        public int position_id;
        public int project_id;
        public float hours;

        // Relations
        public Positions position()
        {
            return new Positions().hasOne(this, "position_id", "position_id");
        }
    }
}
