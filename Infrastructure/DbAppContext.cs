using GestionBiblioMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionBiblioMVC.Infrastructure;

public class DbAppContext : DbContext
{
    public DbAppContext(DbContextOptions<DbAppContext> options) : base(options)
    {
        
    }

    public DbSet<Usuarios>  Usuarios { get; set; }
    public DbSet<Libros>  Libros { get; set; }
    public DbSet<Prestamos>  Prestamos { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Usuarios>().HasIndex(u => u.Documento).IsUnique();
           modelBuilder.Entity<Libros>().HasIndex(l => l.Codigo).IsUnique();

           modelBuilder.Entity<Prestamos>()
               .HasOne(p => p.Usuario)
               .WithMany(u => u.Prestamos)
               .HasForeignKey(p => p.UsuarioId)
               .OnDelete(DeleteBehavior.Cascade);
           
           modelBuilder.Entity<Prestamos>()
               .HasOne(p => p.Usuario)
               .WithMany(l => l.Prestamos)
               .HasForeignKey(p => p.LibrosId)
               .OnDelete(DeleteBehavior.Cascade);
       }
    
}