using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AboutSongs.Models
[Table("Album")]
public class Album
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string AlbumId { get; set; }
    [ForeignKey("ArtistaId")]
    public Artista Artista { get; set; }

    public string Título 
}