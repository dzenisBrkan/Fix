namespace FIX.API.Models.Domain;

public class Messages
{
    public int Id { get; set; }
    public int message_thread_id { get; set; }
    public int sender_id { get; set; }
    public int receiver_id { get; set; }
    public string message_text { get; set; }
    public DateTime sent_at { get; set; }
}
