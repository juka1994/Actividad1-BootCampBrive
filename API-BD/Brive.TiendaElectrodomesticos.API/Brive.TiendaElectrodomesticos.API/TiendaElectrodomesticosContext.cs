using Brive.TiendaElectrodomesticos.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.TiendaElectrodomesticos.API
{
    public class TiendaElectrodomesticosContext: DbContext
    {
        public TiendaElectrodomesticosContext(DbContextOptions<TiendaElectrodomesticosContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElectronicDevice>(eb =>
            {
                eb.HasKey(c => new { c.Id });
            });
        }
        public DbSet<ElectronicDevice> ElectronicDevice { get; set; }
    }
}
