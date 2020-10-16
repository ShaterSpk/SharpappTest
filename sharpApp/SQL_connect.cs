using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sharpApp
{
    class SQL_connect
    {
        public SqlConnection cnn;
        public void Connection()
        {
            cnn = new SqlConnection("Data Source = csharpapptest.database.windows.net; Initial Catalog = csharpapp; User ID = Shather; Password = Mi57062694; Connect Timeout = 60; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            
        }
    }
}
