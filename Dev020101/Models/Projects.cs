using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class Projects : MySqlModel<Projects>
    {
        public int project_id;
        public string name;
        public float budget;
        public int allocatedHours;
        public int address_id;
        public string buildingName;

        // Relations
        public Addresses address()
        {
            return new Addresses().hasOne(this, "address_id", "address_id");
        }

        public Headquarters headquarter()
        {
            return new Headquarters().hasOne(this, "buildingName", "buildingName");
        }
    }
}
