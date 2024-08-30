using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AboutSongs.Models;
[Table("Musica")]
public class Musica
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Título")]
    [StringLength(100)]
    public string Título { get; set; }

    [Required(ErrorMessage = "Por favor, informe os Compositores")]
    [StringLength(100)]
    public string Compositores { get; set; }
    
    public TimeSpan Duracao { get; set; }

    public ICollection<MusicaGenero> Generos { get; set; }
    
    public ICollection<AlbumArtista> AlbunsArtistas { get; set; }

}