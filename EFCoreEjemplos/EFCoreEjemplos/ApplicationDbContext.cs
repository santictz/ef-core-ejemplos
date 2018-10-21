using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEjemplos
{
    class ApplicationDbContext: DbContext
    {
        //Especificar qué motor de DB vamos a utilizar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PruebaEFCoreConsola;Integrated Security=True")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }

        //Crear la tabla usando DBSet: basaddo en el modelo Estudiante, con nombre Estudiantes
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
