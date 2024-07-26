using AboutSongs.Models;
using AboutSongs.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AboutSongs.Data;
public class AppDbContext : IdentityDbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {      
    }
    public DbSet<Album> Albuns { get; set;}
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Critica> Criticas { get; set; } 
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}
protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
    AppDbSeed seed = new(builder);

    #region Relacionamento de Muitos para Muitos - Artista

    builder.Entity<Artista>()
        .HasOne(a => a.Musica)
        .WithMany(m => m.Artista)
        .HasForeignKey(a => a.MusicaId);

    builder.Entity<Artista>()
        .HasOne(a => a.Album)
        .WithMany(a => a.Artista)
        .HasForeignKey(a => a.AlbumId);
        
    builder.Entity<Artista>()
        .HasOne(a => a.Album)
        .WithMany(a => a.Artista)
        .HasForeignKey(a => a.AlbumId);
}