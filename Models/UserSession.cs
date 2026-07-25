namespace EventEase.Models;

public class UserSession
{
    public string? CurrentUserName { get; set; }

    public int? LastViewedEventId { get; set; }

    public int RegistrationsCount { get; set; }
}
