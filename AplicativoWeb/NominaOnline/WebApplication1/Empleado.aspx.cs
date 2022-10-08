using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
--******************************************************                                                       
-- Proyecto:      Nomina
-- Responsable:   Daniel Oueilhe  
-- Fecha:         2020-10-08
-- Descripcion:   Interfas para usuario
-- ID:                                                                               
--******************************************************  
*/

namespace WebApplication1
{
    public partial class Empleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string Buscar(string numero)
        {
            Capa.Negocio.CalculoNegocio calculoNegocio = new Capa.Negocio.CalculoNegocio();

            return calculoNegocio.Buscar(long.Parse(numero));
        }
        [WebMethod]
        public static string CalculoSalario(string numero, string anio, string mes)
        {
            Capa.Negocio.CalculoNegocio calculoNegocio = new Capa.Negocio.CalculoNegocio();

            return calculoNegocio.CalculoSalario(long.Parse(numero), int.Parse(anio), int.Parse(mes));
        }
    }
}