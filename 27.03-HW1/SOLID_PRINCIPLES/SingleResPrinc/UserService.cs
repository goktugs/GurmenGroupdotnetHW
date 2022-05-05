namespace SingleResPrinc


    internal interface UserService
{
    bool Login(string username, string password);
    bool Register(string email, string username, string password);
}

internal interface ErrorLogger
{
    void Log(Exception exception, string errorMessage)
}

internal interface EmailSender
{
    void Send(string emailAddress, string content)
}

//Bad Example

internal interface UserBadService
{
    bool Login(string username, string password);
    bool Register(string email, string username, string password);
    void Log(Exception exception, string errorMessage)
    void Send(string emailAddress, string content)

}