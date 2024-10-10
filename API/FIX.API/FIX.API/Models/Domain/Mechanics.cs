namespace FIX.API.Models.Domain;

public class Mechanics
{
    public int Id { get; set; }
    public string mechanic_name { get; set; }
    public string mechanic_surname { get; set; }
    public string mechanic_shop_name { get; set; }
    public string mechanic_type { get; set; }
    public string location { get; set; }
    public bool is_logged_in { get; set; }
    public decimal rating { get; set; }
    public int review_count { get; set; }
    public string working_hours { get; set; }
    public string services_offered { get; set; }
    public DateTime profile_created_at { get; set; }
}