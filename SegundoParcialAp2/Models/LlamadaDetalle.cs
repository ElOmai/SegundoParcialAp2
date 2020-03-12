using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAp2.Models
{
    public class LlamadaDetalle
    {
        [Key]
        public int LlamadaDetalleId { get; set; }
        public int LlamadaId { get; set; }
        [Required]
        public string Problema { get; set; }
        [Required]
        public string Solucion { get; set; }
        public LlamadaDetalle()
        {
            LlamadaDetalleId = 0;
            LlamadaId = 0;
            Problema = string.Empty;
            Solucion = string.Empty;
        }
        public LlamadaDetalle(int llamadaDetalleId,int llamadaId, string problema, string solucion)
        {
            LlamadaDetalleId =  llamadaDetalleId;
            LlamadaId = llamadaId;
            Problema = problema;
            Solucion = solucion;
        }
    }
}
