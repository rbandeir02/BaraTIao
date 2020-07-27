using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelBaraTIao;

namespace BaraTIao.Data
{
    public class BaratiaoContext : DbContext
    {

        public BaratiaoContext(DbContextOptions<BaratiaoContext> options) : base(options)
        {
        }

        public DbSet<Bairro> Bairros { get; set; }
        //public DbSet<Bakery> Bakeries { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=192.168.25.22;Database=Baratiao;user=root;password=q1w2e3");
        }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
