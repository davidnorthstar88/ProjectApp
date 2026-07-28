using System.ComponentModel.DataAnnotations;

namespace ProjectApp.Models;

public class Registration
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string FullName { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Phone]
    public string Phone { get; set; } = string.Empty;

    [Range(1, 10)]
    public int Tickets { get; set; } = 1;

    [Required]
    public int EventId { get; set; }

    public bool AcceptedTerms { get; set; }
}
