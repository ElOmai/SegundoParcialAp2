using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAp2.Models
{
    public class LlamadaDetalle
    {
        public int LlamadaDetalleId { get; set; }
        public string Problema { get; set; }
        public string Solucion { get; set; }
        public LlamadaDetalle()
        {
            LlamadaDetalleId = 0;
            Problema = string.Empty;
            Solucion = string.Empty;
        }
        public LlamadaDetalle(int llamadaDetalleId, string problema, string solucion)
        {
            LlamadaDetalleId =  llamadaDetalleId;
            Problema = problema;
            Solucion = solucion;
        }
    }
}
