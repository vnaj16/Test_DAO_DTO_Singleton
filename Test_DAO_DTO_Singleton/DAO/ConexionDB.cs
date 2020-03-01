using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Test_DAO_DTO_Singleton.DAO
{
    class ConexionDB
    {
        protected SqlConnection Conexion = new SqlConnection(@"Data Source = ARTHUR\VNAJ_DB01; Initial Catalog = dbTestPersona; Integrated Security = true");
    }
}
