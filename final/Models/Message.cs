namespace final.Models;


public class Message
{
    public string? Name { get; set; }
    public string? Email { get; set; }

    public string? Text { get; set; }

    public Message(string name, string mail, string text)
    {
        Name = name;
        Email = mail;
        Text = text;
    }

}