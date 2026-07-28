using ProjectApp.Models;

namespace ProjectApp.Services;

public class AttendanceService
{
    private readonly List<AttendanceRecord> _records = new();

    public IEnumerable<AttendanceRecord> GetAll() => _records;

    public void MarkAttendance(int registrationId, string name, bool present)
    {
        var existing = _records.FirstOrDefault(r => r.RegistrationId == registrationId);

        if (existing is null)
        {
            _records.Add(new AttendanceRecord
            {
                RegistrationId = registrationId,
                AttendeeName = name,
                Present = present
            });
        }
        else
        {
            existing.Present = present;
        }
    }

    public int TotalPresent =>
        _records.Count(r => r.Present);

    public int TotalRegistered =>
        _records.Count();
}
