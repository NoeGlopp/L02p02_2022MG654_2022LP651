using Microsoft.EntityFrameworkCore;

namespace L02p02_2022MG654_2022LP651.Models
{
    public class libreriaDbContext : DbContext
    {
        public libreriaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<clientes> clientes { get; set; }
        public DbSet<autores> autores { get; set; }
        public DbSet<categorias> categorias { get; set; }
        public DbSet<libros> libros { get; set; }
        public DbSet<comentarios_libros> comentarios_libros { get; set; }
        public DbSet<pedido_encabezado> pedido_encabezado { get; set; }
        public DbSet<pedido_detalle> pedido_detalle { get; set; }

    }
}