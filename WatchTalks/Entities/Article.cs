using System.ComponentModel.DataAnnotations;

namespace WatchTalks.Entities;

public class Article
{
        public int Id { get; set; }
        [Microsoft.Build.Framework.Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Title { get; set; }
        [Microsoft.Build.Framework.Required]
        [MinLength(1)]
        [MaxLength(5000)]
        public string Content { get; set; }
        [Microsoft.Build.Framework.Required]
        public DateTime PublishDate { get; set; }
        public List<Comment> Comments { get; set; }
}