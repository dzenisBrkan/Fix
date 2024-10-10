using System.ComponentModel.DataAnnotations.Schema;

namespace FIX.API.Models.Domain;

public class CarParts
{
    public int Id { get; set; }
    public string part_name { get; set; }
    public decimal price { get; set; }


    [ForeignKey("SupplierId")]
    public int SupplierId { get; set; } 
    public Suppliers Supplier { get; set; }

    public int compatible_models { get; set; }
    public bool availability { get; set; }
    public string part_description { get; set; }
    public string warranty_period { get; set; }
}