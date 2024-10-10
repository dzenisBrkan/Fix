using System.ComponentModel.DataAnnotations.Schema;

namespace FIX.API.Models.Domain;

public class Notifications
{
    public int Id { get; set; }

    [ForeignKey("UserId")]
    public int UserId { get; set; }
    public Users User { get; set; }

    public string message { get; set; }
    public bool is_read { get; set; }
    public string notification_type { get; set; }
    public DateTime created_at { get; set; }
}