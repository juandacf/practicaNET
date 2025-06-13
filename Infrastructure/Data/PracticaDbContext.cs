using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //Este namespace es el que contiene el DBcontext.

namespace Infrastructure.Data
{
    public class PracticaDbContext : DbContext  //Clase nativa de EF. Esta conecta nuestras clases con la bdd.
    {
        public PracticaDbContext(DbContextOptions<PracticaDbContext> options) : base(options) //Constructor para instanciar la conexión a la bdd. Las options de parámetro, se incluirán en Program.cs
        {
        }
        // Los DbSet son los que posteriormente serán incluidos en la bdd
        protected override void OnModelCreating(ModelBuilder modelBuilder) //Método sobrescrito de DbContext.
        {
            base.OnModelCreating(modelBuilder); //Mantener las configuraciones del EF por defect.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Busca automáticamente todas las clases en este proyecto que implementen IEntityTypeConfiguration<T> y aplícalas al modelo interno que .NET crea en memoria, mo al de la bdd.
        }
        
    }
}