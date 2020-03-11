using Microsoft.EntityFrameworkCore;
using SegundoParcialAp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAp2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Prueba> Pruebas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Database/Data.db");
        }
    }
}
