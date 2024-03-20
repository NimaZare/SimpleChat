namespace SimpleChat.Server.Model;

public class MessageModel
{
    public int Id { get; set; }
    public required string Sender { get; set; }
    public required string Message { get; set; }
    public DateTime MessageDateTime { get; set; } = DateTime.Now;
}
