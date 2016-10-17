using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    class Courses : MySqlModel<Courses>
    {
        public int course_id;
        public string name;
    }
}
