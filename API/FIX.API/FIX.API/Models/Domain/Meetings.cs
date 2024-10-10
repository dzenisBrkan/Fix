using System.ComponentModel.DataAnnotations.Schema;

namespace FIX.API.Models.Domain;

public class Meetings
{
    //Expand this table to Apintment Model
    //Design the Appointment Model:

    //Fields: userId, mechanicId, serviceType, appointmentDate, appointmentTime, status, createdAt, updatedAt.
    //Enum for status: pending, confirmed, rejected, completed.

    public int Id { get; set; }

    [ForeignKey("UserId")]
    public int UserId { get; set; }
    public Users User { get; set; }


    [ForeignKey("MechanicId")]
    public int MechanicId { get; set; }
    public Mechanics Mechanic { get; set; }

    public DateTime meeting_date { get; set; }
    public string status { get; set; }
    public DateTime last_updated { get; set; }
    public int message_thread_id { get; set; }
}