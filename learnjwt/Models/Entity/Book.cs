using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace learnjwt.Models.Entity;

public class Book
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(5)]
    public string Code { get; set; }

    [Required, StringLength(50)]
    public string Name { get; set; }

    public string Description { get; set; }

    [Column(TypeName = "text")]
    public string Image { get; set; }

    [ForeignKey("User")]
    public int UserID { get; set; }
    public User User { get; set; }
}