using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Models
{
    public class Addresses : MySqlModel<Addresses>
    {
        public int address_id;
        public string number;
        public string postalCode;
        public int street_name;
        public int country_name;
        public int city_name; 
    }
}
