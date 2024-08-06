using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AboutSongs.Models;

[Table("Comentario")]

public class Comentario
{
    [Key]
    public int Id { get; set; }
    
}
