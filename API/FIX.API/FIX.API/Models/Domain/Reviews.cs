using System.ComponentModel.DataAnnotations.Schema;

namespace FIX.API.Models.Domain;

public class Reviews
{
    public int Id { get; set; }

    [ForeignKey("UserId")]
    public int UserId { get; set; }
    public Users User { get; set; }

    [ForeignKey("MechanicId")]
    public int MechanicId { get; set; }
    public Mechanics Mechanic { get; set; }

    public decimal rating { get; set; }
    public string review_text { get; set; }
    public DateTime review_date { get; set; }
}