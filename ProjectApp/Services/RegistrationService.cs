using ProjectApp.Models;

namespace ProjectApp.Services;

public class RegistrationService
{
    private readonly List<Registration> _registrations = new();
    private int _nextId = 1;

    public Registration Add(Registration registration)
    {
        registration.Id = _nextId++;
        _registrations.Add(registration);
        return registration;
    }

    public IEnumerable<Registration> GetByEvent(int eventId) =>
        _registrations.Where(r => r.EventId == eventId);

    public Registration? GetById(int id) =>
        _registrations.FirstOrDefault(r => r.Id == id);
}
