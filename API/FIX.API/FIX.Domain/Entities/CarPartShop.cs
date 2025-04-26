namespace FIX.Domain.Entities;

public class CarPartShop
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Address { get; set; }
    public bool PhoneNumber { get; set; }
    public bool Website { get; set; }
    public decimal Rating { get; set; }
    public ICollection<Review> Reviews { get; set; }
}