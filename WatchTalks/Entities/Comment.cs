using System.ComponentModel.DataAnnotations;

namespace WatchTalks.Entities;

public class Comment
{
    public int Id { get; set; }
    [Required]
    [MinLength(5)]
    [MaxLength(15)]
    public User Author { get; set; }
    [Required]
    [MinLength(20)]
    [MaxLength(500)]
    public string Content { get; set; }
    [Required]
    public DateTime DatePosted { get; set; }
    public List<Comment> Responses { get; set; }
}