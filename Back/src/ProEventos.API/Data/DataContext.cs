
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Options = options;
        }
        public DbSet<Evento> Eventos { get; set; }
        public DbContextOptions<DataContext> Options { get; }
    }
}