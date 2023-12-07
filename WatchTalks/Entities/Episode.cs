using System.ComponentModel.DataAnnotations;

namespace WatchTalks.Entities;

public class Episode
{
    public int Id { get; set; }
    [Required]
    [MinLength(1)]
    [MaxLength(100)]
    public string Title { get; set; }
    [Required]
    [MinLength(1)]
    [MaxLength(500)]
    public string Description { get; set; }
    [Required]
    public Season Season { get; set; }
    [Required]
    public int EpisodeNumber { get; set; }
    [Required]
    public DateTime ReleaseDate { get; set; }
    [Required]
    [Range(0, 100)]
    public int Rating { get; set; }
    public List<Comment> Comments { get; set; }
}