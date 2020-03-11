using SegundoParcialAp2.Data;
using SegundoParcialAp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SegundoParcialAp2.Controllers
{
    public class LlamadaDetalleController
    {
        public List<LlamadaDetalle> GetLlamada(Expression<Func<LlamadaDetalle, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<LlamadaDetalle> lista;
            try
            {
                lista = contexto.LlamadaDetalles.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
        public LlamadaDetalle Buscar(int id)
        {
            Contexto contexto = new Contexto();
            LlamadaDetalle Llamada = new LlamadaDetalle();
            try
            {
                Llamada = contexto.LlamadaDetalles.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return Llamada;
        }
    }
}
