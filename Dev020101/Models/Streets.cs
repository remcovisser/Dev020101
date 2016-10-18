using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class Streets : MySqlModel<Streets>
    {
        public int street_id;
        public string street_name;
    }
}
