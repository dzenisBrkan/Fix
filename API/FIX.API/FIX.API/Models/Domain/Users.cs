namespace FIX.API.Models.Domain;

public class Users
{
    public int Id { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public string location { get; set; } //Expand
    public bool is_logged_in { get; set; }
    public string wishlist { get; set; }
    public int review_count { get; set; }
    public decimal average_rating { get; set; }
    public DateTime profile_created_at { get; set; }
}