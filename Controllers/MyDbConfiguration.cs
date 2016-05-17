using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class MyDbConfiguration : DbConfiguration
    {
        public MyDbConfiguration()
        {
            // Attempt to register ADO.NET provider 
            try
            {
                var dataSet = (DataSet)ConfigurationManager.GetSection("system.data");
                dataSet.Tables[0].Rows.Add(
                    "MySQL Data Provider",
                    ".Net Framework Data Provider for MySQL",
                    "MySql.Data.MySqlClient",
                    typeof(MySqlClientFactory).AssemblyQualifiedName
                );
            }
            catch (ConstraintException)
            {
                // MySQL provider is already installed, just ignore the exception 
            }

            // Register Entity Framework provider 
            SetProviderServices("MySql.Data.MySqlClient", new MySqlProviderServices());
            SetDefaultConnectionFactory(new MySqlConnectionFactory());
        }
    }
}
