using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class Schools : MySqlModel<Schools>
    {
        public int school_id;
        public string school_name;
    }
}
