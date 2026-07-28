namespace ProjectApp.Models;

public class AttendanceRecord
{
    public int RegistrationId { get; set; }

    public string AttendeeName { get; set; } = string.Empty;

    public bool Present { get; set; }
}
