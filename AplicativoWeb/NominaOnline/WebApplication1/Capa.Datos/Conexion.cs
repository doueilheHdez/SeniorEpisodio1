using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Capa.Datos
{
    public class Conexion
    {
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cnnString"].ConnectionString;
        public Conexion()
        {
        }
    }
}