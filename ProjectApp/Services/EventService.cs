using ProjectApp.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<Event> _events = new()
    {
        new Event
        {
            Id = 1,
            Name = "Corporate Summit",
            Date = DateTime.Today.AddDays(7),
            Location = "Atlanta HQ",
            Capacity = 200,
            Description = "Annual corporate strategy summit."
        },
        new Event
        {
            Id = 2,
            Name = "Social Mixer",
            Date = DateTime.Today.AddDays(14),
            Location = "Downtown Lounge",
            Capacity = 80,
            Description = "Networking and social event."
        }
    };

    public IReadOnlyList<Event> GetEvents() => _events;

    public Event? GetEventById(int id) =>
        _events.FirstOrDefault(e => e.Id == id);

    public void UpdateEvent(Event updated)
    {
        var existing = GetEventById(updated.Id);
        if (existing is null) return;

        existing.Name = updated.Name;
        existing.Date = updated.Date;
        existing.Location = updated.Location;
        existing.Capacity = updated.Capacity;
        existing.Description = updated.Description;
    }
}
