using System.ComponentModel.DataAnnotations;

namespace WatchTalks.Entities;

public class Season
{
    public int Id { get; set; }
    [Required]
    public Series Series { get; set; }
    [Required]
    public int SeasonNumber { get; set; }
    public List<Episode> Episodes { get; set; }
}