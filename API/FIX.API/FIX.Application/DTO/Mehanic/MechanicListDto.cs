namespace FIX.Application.DTO.Mehanic;

public class MechanicListDto
{
    public int Id { get; set; }
    public string MechanicShopName { get; set; }
    public string Location { get; set; }
    public decimal Rating { get; set; }
    public int ReviewCount { get; set; }
    public string Specialization { get; set; }
    public string PhotoUrl { get; set; }
}