namespace FIX.Application.DTO.Mehanic;

public class MechanicDetailDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MechanicShopName { get; set; }
    public string Location { get; set; }
    public string PhoneNumber { get; set; }

    public string WorkingDays { get; set; }
    public string WorkingHoursFrom { get; set; }
    public string WorkingHoursTo { get; set; }

    public string ServicesOffered { get; set; }
    public string Experience { get; set; }
    public string Specialization { get; set; }

    public DateTime? VacationDate { get; set; }
    public string PhotoUrl { get; set; }

    public decimal Rating { get; set; }
    public int ReviewCount { get; set; }
}