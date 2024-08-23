using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBlog.Models;

public class Comment
{
    public int Id { get; set; }
    [StringLength(14, MinimumLength = 1)]
    [Required]
    [DisplayName("コメントした人")]
    public string Author { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    [DisplayName("コメントした日")]
    public DateTime CreatedAt { get; set; }
    [StringLength(100, MinimumLength = 1)]
    [Required]
    [DisplayName("コメント内容")]
    public string Content { get; set; } = string.Empty;
    [DisplayName("ブログ")]
    public int BlogId { get; set; }
    public required Blog Blog { get; set; }
}