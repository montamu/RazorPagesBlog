using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBlog.Models;
public class Blog
{
    public int Id { get; set; }
    [StringLength(30, MinimumLength = 1)]
    [Required]
    [DisplayName("タイトル")]
    public string Title { get; set; } = string.Empty;
    [StringLength(14, MinimumLength = 1)]
    [Required]
    [DisplayName("書いた人")]
    public string Author { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    [DisplayName("投稿日")]
    public DateTime PostDate { get; set; }
    [StringLength(800, MinimumLength = 1)]
    [Required]
    [DisplayName("内容")]
    public string Content { get; set; } = string.Empty;
    public int Like { get; set; }
}