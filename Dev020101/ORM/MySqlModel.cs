using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dev020101.Interfaces;
using Dev020101.Models;

namespace Dev020101.ORM
{
    public class MySqlModel<T> : Model<T>, IModel<T, MySqlModel<T>>
    {
        MySqlConnection connection;
        Model<T> baseModel;
        string table;
        string query;
        string selectedFields;

        public MySqlModel()
        {
            baseModel = new Model<T>();
            connection = baseModel.MySqlconnection;
            table = this.GetType().Name.ToLower();
            query = "SELECT * FROM " + table;
            selectedFields = null;
        }

        public MySqlModel<T> and(string field, string comparisonOperator, object value)
        {
            return logicalOperatorBuilder("and", field, comparisonOperator, value);
        }

        public int count()
        {
            List<T> results = get();

            return results.Count;
        }

        public bool delete()
        {
            FieldInfo[] fields = this.GetType().GetFields();
            query = "delete from " + table;

            foreach (FieldInfo field in fields)
            {
                if(fields.First() == field)
                {
                    query += " where " + field.Name + " = " + "'" + this.GetType().GetField(field.Name).GetValue(this) + "'";
                } 
                else
                {
                    query += " and " + field.Name + " = " + "'" + this.GetType().GetField(field.Name).GetValue(this) + "'";
                }
            }

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            return true;
        }

        public MySqlModel<T> find<U>(U value, string field = null)
        {
            if (field == null)
            {
                query += " where id = '" + value + "'";
            } 
            else
            {
                query += " where " + field + " = '" + value + "'";
            }

            return this;
        }

        public MySqlModel<T> first()
        {
            query += " limit 1 ";

            return this;
        }

        public MySqlModel<T> last(string field = null)
        {
            if(field == null)
            {
                field = "id";
            }
            query += " order by " + field + " DESC limit 1 ";

            return this;
        }

        public List<Tuple<int, string, FieldInfo>> formatData(MySqlDataReader data)
        {
            FieldInfo[] fields = this.GetType().GetFields();
            int fieldCount = fields.Count();
            int x = 0;
            List<Tuple<int, string, FieldInfo>> formatedData = new List<Tuple<int, string, FieldInfo>>();

            while (data.Read())
            {
                for (int i = 0; i < fieldCount; i++)
                {
                    if (i % fieldCount == 0)
                    {
                        x++;
                    }

                    formatedData.Add(new Tuple<int, string, FieldInfo>(x, data.GetString(i), fields[i]));
                }
            }
            data.Close();

            return formatedData;
        }

        public List<T> get()
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.ClearAllPoolsAsync();
         
            return baseModel.createInstaces(typeof(T), this.formatData(command.ExecuteReader()));
        }

        public T grab()
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.ClearAllPoolsAsync();

            return baseModel.createInstaces(typeof(T), this.formatData(command.ExecuteReader())).First();
        }

        public MySqlModel<T> groupby(string field)
        {
            return logicalOperatorBuilder("group by", field, null, null);
        }

        private void buildRelationQuery<U>(U parent, string leftTableField = null, string rightTableField = null)
        {
            if (leftTableField == null)
            {
                string parentName = this.GetType().Name.ToLower();
                leftTableField = parentName.Remove(parentName.Length - 1) + "_id";
            }

            if (rightTableField == null)
            {
                string parentName = this.GetType().Name.ToLower();
                rightTableField = parentName.Remove(parentName.Length - 1) + "_id";
            }

            query += " where " + rightTableField + " = '" +  parent.GetType().GetField(leftTableField).GetValue(parent) + "'";
        }

        public List<T> hasMany<U>(U parent, string leftTableField = null, string rightTableField = null)
        {
            buildRelationQuery(parent, leftTableField, rightTableField);

            return this.get();
        }

        public T hasOne<U>(U parent, string leftTableField = null, string rightTableField = null)
        {
            buildRelationQuery(parent, leftTableField, rightTableField);

            return this.grab();
        }

        public MySqlModel<T> logicalOperatorBuilder(string logicalOperator, string field, string comparisonOperator, object value)
        {
            // Group By
            if (value == null && comparisonOperator == null)
            {
                query += " " + logicalOperator.ToUpper() + " " + "'" + field + "'";
            }
            // Order By
            else if (value == null)
            {
                query += " " + logicalOperator.ToUpper() + " " + field + " " + comparisonOperator;
            }
            // Where
            else
            {
                query += " " + logicalOperator.ToUpper() + " " + field + " " + comparisonOperator + " " + "'" + value + "'";
            }

            return this;
        }

        public MySqlModel<T> or(string field, string comparisonOperator, object value)
        {
            return logicalOperatorBuilder("or", field, comparisonOperator, value);
        }

        public MySqlModel<T> orderby(string field, string sort)
        {
            return logicalOperatorBuilder("order by", field, sort, null);
        }

        public bool save()
        {
            List<Tuple<string, object>> formatedData = baseModel.saveOrUpdate(this, table);
            query = "insert into " + table;
            string fields = "(";
            string data = "(";

            foreach (Tuple<string, object> item in formatedData)
            {
                fields += item.Item1 + ",";
                data += "'" + item.Item2 + "',";
            }
            fields = fields.Remove(fields.Length - 1);
            data = data.Remove(data.Length - 1);

            query += fields + ") values " + data + ")";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            return true;
        }

        public MySqlModel<T> select(string fields)
        {
            selectedFields = fields;
            string[] selectedFieldsList = selectedFields.Replace(" ", string.Empty).Split(',');

            query = "select ";
            foreach (string selectedField in selectedFieldsList)
            {
                query += " " + selectedField;
                if (!selectedField.Equals(selectedFieldsList.Last()))
                {
                    query += ",";
                }
            }
            query += " from " + table;

            return this;
        }

        public int sum(string value)
        {
            List<T> results = get();
            int sum = 0;

            foreach (T result in results)
            {
                sum += Convert.ToInt32(result.GetType().GetField(value).GetValue(result));
            }

            return sum;
        }

        public bool update(string field = null, object value = null)
        {
            List<Tuple<string, object>> formatedData = baseModel.saveOrUpdate(this, table);
            query = "update " + table + " set ";
            string fieldsAndData = "";

            foreach (Tuple<string, object> item in formatedData)
            {
                fieldsAndData += item.Item1 + "='" + item.Item2 + "',";
            }
            fieldsAndData = fieldsAndData.Remove(fieldsAndData.Length - 1);

            if(field == null)
            {
                query += fieldsAndData + " where id = ";
            }
            else
            {
                query += fieldsAndData + " where " + field + " = ";
            }

            if(value == null)
            {
                value = this.GetType().GetFields().First().GetValue(this);
            }

            query += "'" + value + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            return true;
        }

        public MySqlModel<T> where(string field, string comparisonOperator, object value)
        {
            return logicalOperatorBuilder("where", field, comparisonOperator, value);
        }
    }
}