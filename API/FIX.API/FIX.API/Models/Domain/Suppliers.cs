namespace FIX.API.Models.Domain;

public class Suppliers
{
    public int Id { get; set; }
    public string supplier_name { get; set; }
    public string location { get; set; }
    public string contact_info { get; set; }
    public int stock_level { get; set; }
    public DateTime last_restocked { get; set; }
}