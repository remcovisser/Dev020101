using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;


namespace Dev020101.Models
{
    public class EmployeeAddresses : MySqlModel<EmployeeAddresses>
    {
        public int employeeAddress_id;
        public string bsn;
        public int address_id;
        public int residence;

        // Relations
        public Addresses address()
        {
            return new Addresses().hasOne(this, "address_id", "address_id");
        }
    }
}
