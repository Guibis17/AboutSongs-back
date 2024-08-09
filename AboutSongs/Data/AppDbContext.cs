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

    public DbSet<Album> Albuns { get; set; }
    public DbSet<AlbumArtista> AlbumArtistas { get; set; }
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Comentario> Comentarios { get; set; }
    public DbSet<Critica> Criticas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<GeneroArtista> GeneroArtistas { get; set; }
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<MusicaGenero> MusicaGeneros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        //AppDbSeed seed = new(builder);

        #region Relacionamento de Muitos para Muitos - Album Artista
        builder.Entity<AlbumArtista>()
            .HasKey(aa => new { aa.AlbumId, aa.ArtistaId });

        builder.Entity<AlbumArtista>()
            .HasOne(aa => aa.Album)
            .WithMany(a => a.Artistas)
            .HasForeignKey(aa => aa.AlbumId);

        builder.Entity<AlbumArtista>()
            .HasOne(aa => aa.Artista)
            .WithMany(a => a.Albuns)
            .HasForeignKey(a => a.ArtistaId);
        #endregion

        #region Relacionamento de Muitos para Muitos - GeneroArtista

        builder.Entity<GeneroArtista>()
            .HasKey(ga => new { ga.GeneroId, ga.ArtistaId });

        builder.Entity<GeneroArtista>()
            .HasOne(ga => ga.Genero)
            .WithMany(g => g.Artistas)
            .HasForeignKey(a => a.GeneroId);

        builder.Entity<GeneroArtista>()
            .HasOne(ga => ga.Artista)
            .WithMany(a => a.Generos)
            .HasForeignKey(g => g.ArtistaId);
        #endregion

        #region Relacionamento de Muitos para Muitos - MusicaGenero

        builder.Entity<MusicaGenero>()
            .HasKey(mg => new { mg.MusicaId, mg.GeneroId });

        builder.Entity<MusicaGenero>()
            .HasOne(mg=> mg.Musica)
            .WithMany(m => m.Generos)
            .HasForeignKey(m=> m.MusicaId);

        builder.Entity<MusicaGenero>()
            .HasOne(mg => mg.Genero)
            .WithMany(g=> g.Musicas)
            .HasForeignKey(g => g.GeneroId);
        #endregion

    }
}