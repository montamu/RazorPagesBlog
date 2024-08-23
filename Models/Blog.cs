using System.ComponentModel.DataAnnotations;

namespace RazorPagesBlog.Models;
public class Blog
{
    public int Id { get; set; }
    [StringLength(14, MinimumLength = 4)]
    [Required]
    public string Author { get; set; } = string.Empty;
    [StringLength(30, MinimumLength = 1)]
    [Required]
    public string Title { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    public DateTime PostDate { get; set; }
    [StringLength(800, MinimumLength = 10)]
    [Required]
    public string Content { get; set; } = string.Empty;
    public int Like { get; set; }
}