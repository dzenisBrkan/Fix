using System.ComponentModel.DataAnnotations.Schema;

namespace FIX.Domain.Entities;

public class Review
{
    public int Id { get; set; }
    public decimal Score { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }

    public int EntityId { get; set; } // ID of Workshop, Mechanic, etc.
    public string EntityType { get; set; } // "Workshop" or "Mechanic"

    [ForeignKey("UserId")]
    public int UserId { get; set; }
    public Users User { get; set; }
}