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
        public int street_id;
        public int city_id;
        public int country_id;
        
        // Relations
        public Countries country()
        {
            return new Countries().hasOne(this, "country_id", "country_id");
        }

        public Cities city()
        {
            return new Cities().hasOne(this, "city_id", "city_id");
        }

        public Streets street()
        {
            return new Streets().hasOne(this, "street_id", "street_id");
        }
    }
}
