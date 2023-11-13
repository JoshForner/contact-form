namespace ContactForm.Models;

using System.ComponentModel.DataAnnotations;

public record Contact
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;
}
