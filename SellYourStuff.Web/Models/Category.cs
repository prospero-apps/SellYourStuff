using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SellYourStuff.Web.Models;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(40)]
    [DisplayName("Category Name")]
    public string Name { get; set; } = string.Empty;
}
