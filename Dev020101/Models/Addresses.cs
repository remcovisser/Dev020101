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
        public string city_name;
        public string country_name;
        public string street_name;
    }
}
