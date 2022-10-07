using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Capa.Datos
{
    public class Conexion
    {
        public static string ConnectionString = "data source=localhost;initial catalog=PracticaNomina;integrated security=True;MultipleActiveResultSets=True;Connect Timeout=120;";
        public Conexion() {
        }

    }
}
