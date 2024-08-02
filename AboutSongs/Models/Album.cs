using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AboutSongs.Models;
[Table("Album")]
public class Album
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Título")]
    [StringLength(100)]
    public string Título { get; set; }

    [StringLength(100)]
    public string Capa { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataDeLancamento { get; set; }
    public ICollection<AlbumArtista> Artistas { get; set; }
}