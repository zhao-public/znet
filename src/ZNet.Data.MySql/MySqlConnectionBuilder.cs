using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Data.MySqlxx
{
    public class MySqlConnectionBuilder : IDatabaseConnectionBuilder
    {
        public bool Readonly { get; set; }

        public string GetConnectionString()
        {
            MySql.Data.MySqlClient.MySqlConnectionStringBuilder builder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder("");

            return "";
        }
    }
}
