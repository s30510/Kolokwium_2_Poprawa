using System.ComponentModel.DataAnnotations;

namespace CodeFirstTemplate.Models;

public class Example
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
}