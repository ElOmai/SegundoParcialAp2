using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAp2.Models
{
    public class Llamada
    {
        [Key]
        public int LlamadaId { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("LlamadaId")]

        public List <LlamadaDetalle> Detalles;
        
        public Llamada()
        {
            LlamadaId = 0;
            Descripcion = string.Empty;
            Detalles = new List<LlamadaDetalle>();
        }
    }
}
