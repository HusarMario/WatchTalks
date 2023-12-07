using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WatchTalks.Entities;

public class User
{
    public int Id { get; set; }
    [Required]
    [MinLength(5)]
    [MaxLength(15)]
    public string Username { get; set; }
    [Required]
    [PasswordPropertyText]
    [MinLength(8)]
    [MaxLength(15)]
    public string Password { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    public List<Comment> Comments { get; set; }
}