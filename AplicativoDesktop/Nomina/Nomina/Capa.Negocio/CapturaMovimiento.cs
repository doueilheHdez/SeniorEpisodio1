using Nomina.Capa.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Capa.Negocio
{
    public class CapturaMovimiento
    {
        public long Numero { get; set; }
        public string Fecha { get; set; }
        public int CantidadEntrega { get; set; }
        public bool CubrioTurno { get; set; }
        public string CubrioTurnoTipo { get; set; }
        public string CubrioTurnoRol { get; set; }
        public CapturaMovimiento(long numero, string fecha, int cantidadEntrega, bool cubrioTurno, string cubrioTurnoTipo, string cubrioTurnoRol)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.CantidadEntrega = cantidadEntrega;
            this.CubrioTurno = cubrioTurno;
            this.CubrioTurnoTipo = cubrioTurnoTipo;
            this.CubrioTurnoRol = cubrioTurnoRol;
        }
    }
}
