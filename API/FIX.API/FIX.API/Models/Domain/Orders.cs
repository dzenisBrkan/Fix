using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIX.API.Models.Domain;

public class Orders
{
    public int Id { get; set; }

    [ForeignKey("MechanicId")]
    public int? MechanicId { get; set; }
    public Mechanics Mechanic { get; set; }

    [ForeignKey("SupplierId")]
    public int? SupplierId { get; set; }
    public Suppliers Supplier { get; set; }

    [ForeignKey("CarPartId")]
    public int? CarPartId { get; set; }
    public CarParts CarPart { get; set; }


    public DateTime order_date { get; set; }
    public DateTime expected_delivery { get; set; }
    public string status { get; set; }
    public string order_notes { get; set; }
}