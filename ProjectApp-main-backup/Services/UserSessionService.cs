using ProjectApp.Models;

namespace ProjectApp.Services;

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
