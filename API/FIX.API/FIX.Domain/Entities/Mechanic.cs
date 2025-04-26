namespace FIX.Domain.Entities;

public class Mechanic
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MechanicShopName { get; set; }
    public string Location { get; set; }
    public string PhoneNumber { get; set; }

    public decimal Rating { get; set; }
    public int ReviewCount { get; set; }

    public string WorkingDays { get; set; }
    public string WorkingHoursFrom { get; set; } // Example: "08:00"
    public string WorkingHoursTo { get; set; }   // Example: "16:00"

    public string ServicesOffered { get; set; } // maybe later List<Service>

    public string Experience { get; set; }      // Example: "10 years"
    public string Specialization { get; set; }  // Example: "BMW, Audi, Mercedes"

    public DateTime? VacationDate { get; set; }  // Nullable, because maybe no vacation
    public string PhotoUrl { get; set; }

    public ICollection<Review> Reviews { get; set; }
}