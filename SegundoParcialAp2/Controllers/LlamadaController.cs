using Microsoft.EntityFrameworkCore;
using SegundoParcialAp2.Data;
using SegundoParcialAp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SegundoParcialAp2.Controllers
{
    public class LlamadaController
    {
        public bool Guardar(Llamada Llamada)
        {
            bool paso = false;
            try
            {
                if (Llamada.LlamadaId == 0)
                {
                    paso = Insertar(Llamada);
                }
                else
                {
                    paso = Modificar(Llamada);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        private bool Insertar(Llamada Llamada)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {

                contexto.Llamadas.Add(Llamada);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Llamada Llamada)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var anterior = Buscar(Llamada.LlamadaId);
                contexto.Llamadas.Add(Llamada);
                foreach (var item in anterior.Detalles)
                {
                    if (!Llamada.Detalles.Any(p => p.LlamadaDetalleId == item.LlamadaDetalleId))
                    {
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }
                foreach (var item in Llamada.Detalles)
                {
                    if (item.LlamadaDetalleId == 0)
                    {
                        contexto.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }
                contexto.Entry(Llamada).State = EntityState.Modified;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Llamada Buscar(int id)
        {
            Contexto contexto = new Contexto();
            LlamadaDetalleController detallesController = new LlamadaDetalleController();
            Llamada Llamada = new Llamada();
            try
            {
                Llamada = contexto.Llamadas.Find(id);
                if (Llamada != null)
                {
                    Llamada.Detalles = detallesController.GetLlamada(A => A.LlamadaDetalleId == id);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Llamada;
        }
        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Llamada Llamada = new Llamada();
            try
            {
                Llamada = contexto.Llamadas.Find(id);
                contexto.Llamadas.Remove(Llamada);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public List<Llamada> GetLlamada(Expression<Func<Llamada, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Llamada> lista;

            try
            {
                lista = contexto.Llamadas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}
