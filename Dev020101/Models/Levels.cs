﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class Levels : MySqlModel<Levels>
    {
        public int level_id;
        public string level_name;
    }
}
