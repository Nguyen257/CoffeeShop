using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public class AbstractDAO
    {
        protected virtual SqlConnection KetNoiCSDL()
        {
            String ConnectionString = @"Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
            return new SqlConnection(ConnectionString);
        }
    }
}
