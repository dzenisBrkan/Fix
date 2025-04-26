namespace FIX.Domain.Entities;

public class Workshop
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string PhoneNumber { get; set; }
    public string OwnerName { get; set; }
    public string Rating { get; set; }
    public string Website { get; set; }
    public string Url { get; set; }
    public ICollection<Mechanic> Mechanics { get; set; }
    public ICollection<Review> Reviews { get; set; }
}