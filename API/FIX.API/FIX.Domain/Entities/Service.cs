using System.ComponentModel.DataAnnotations.Schema;

namespace FIX.Domain.Entities;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime ServiceDate { get; set; }
    public string Status { get; set; }//In progress, Done, On-waiting

    [ForeignKey("MechanicId")]
    public int MechanicId { get; set; }
    public Mechanic Mechanic { get; set; }


    [ForeignKey("WorkshopId")]
    public int? WorkshopId { get; set; }
    public Workshop Workshop { get; set; }
}