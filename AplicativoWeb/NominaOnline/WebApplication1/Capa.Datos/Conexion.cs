using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
--******************************************************                                                       
-- Proyecto:      Nomina
-- Responsable:   Daniel Oueilhe  
-- Fecha:         2022-10-08
-- Descripcion:   Conexion de base de datos
-- ID:                                                                               
--******************************************************  
*/
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