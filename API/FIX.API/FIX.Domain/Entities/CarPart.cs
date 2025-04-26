using System.ComponentModel.DataAnnotations.Schema;

namespace FIX.Domain.Entities;

public class CarPart
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string CompatibleCars { get; set; } // comma-separated or JSON array
    public int CompatibleModels { get; set; }
    public decimal Price { get; set; }
    public bool Availability { get; set; }
    public string Description { get; set; }
    public string WarrantyPeriod { get; set; }
    public bool InStock { get; set; }

    [ForeignKey("CarPartShopId")]
    public int CarPartShopId { get; set; }
    public CarPartShop CarPartShop { get; set; }
}