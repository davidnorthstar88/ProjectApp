using ProjectApp.Models;

namespace EventEase.Services;

public class UserSessionService
{
    public UserSession Session { get; } = new();

    public void SetUser(string name) =>
        Session.CurrentUserName = name;

    public void SetLastViewedEvent(int eventId) =>
        Session.LastViewedEventId = eventId;

    public void IncrementRegistrations() =>
        Session.RegistrationsCount++;
}
