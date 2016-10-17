using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class Positions : MySqlModel<Positions>
    {
        public int position_id;
        public string name;
        public string description;
        public float fee;
    }
}
