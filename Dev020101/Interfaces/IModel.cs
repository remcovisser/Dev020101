using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Dev020101.ORM;

namespace Dev020101.Interfaces
{
    interface IModel<O, T>
    {
        // Properties
        //Model<O> baseModel { get; set; }
        //string table { get; set; }
        //string query { get; set; }
        //string selectedFields { get; set; }

        // Methods
        bool save();
        bool update(string field = null, object value = null);
        bool delete();
        int count();
        int sum(string value);
        O grab();
        List<O> get();
        T select(string fields);
        T find<U>(U value, string field = null);
        T first();
        T logicalOperatorBuilder(string logicalOperator, string field, string comparisonOperator, object value);
        T where(string field, string comparisonOperator, object value);
        T and(string field, string comparisonOperator, object value);
        T or(string field, string comparisonOperator, object value);
        T orderby(string field, string sort);
        T groupby(string field);
        O hasOne<U>(U parent, string customField = null);
        List<O> hasMany<U>(U parent, string customField = null);
        List<Tuple<int, string, FieldInfo>> formatData(MySqlDataReader data);
    }
}
