using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class Degrees : MySqlModel<Degrees>
    {
        public int degree_id;
        public int course_id;
        public int school_id;
        public int level_id;

        // Relations
        public Courses course()
        {
            return new Courses().hasOne(this, "course_id", "course_id");
        }

        public Schools school()
        {
            return new Schools().hasOne(this, "school_id", "school_id");
        }

        public Levels level()
        {
            return new Levels().hasOne(this, "level_id", "level_id");
        }
    }
}
