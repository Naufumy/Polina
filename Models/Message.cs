namespace ApologySite.Models
{
    public class Message
    {
    public int Id { get; set; }
    public string? Date { get; set; }
    public string? Who { get; set; }
    public string? Reason { get; set; }
    public string? Wish { get; set; }
    public bool IsDone { get; set; } = false;
    }
}