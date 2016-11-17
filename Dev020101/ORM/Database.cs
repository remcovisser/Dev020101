using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dev020101.ORM
{
    class Database
    {
        string server, user, password, database;
        public string type;
        public static MySqlConnection connection;

        // Database settings
        public Database()
        {
            this.server = "localhost";
            this.user = "root";
            this.password = "root";
            this.database = "assignment1";
            this.type = "mysql";
        }
       
        public void connect()
        { 
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = this.server;
            builder.UserID = this.user;
            builder.Password = this.password;
            builder.Database = this.database;

            MySqlConnection con = new MySqlConnection(builder.ToString());
            con.Open();

            connection = con;
        }
    }
}
