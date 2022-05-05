// Low level module
public class EmailSender : IEmailSender
{
    public void Send(string email, string content)
    {
        Console.WriteLine($"Sending email to {email}");
    }
}

// High level module

// Abstraction
public interface IEmailSender
{
    void Send(string email, string content);
}

public class OrderService
{
    private readonly IEmailSender _emailSender;

    public OrderService(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public void CreateOrder()
    {
        Console.WriteLine("Creating order");

        //Sending order details
        _emailSender.Send("goktugsevgil@gmail.com", "This is order detail.");
    }
}

// Bad design can be tightly dependent on low level module(email sender) .