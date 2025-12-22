namespace DesignPatterns.Structural.Proxy;

public sealed class UserContext
{
    public string UserName { get; }
    public bool IsAdmin { get; }

    public UserContext(string userName, bool isAdmin)
    {
        UserName = userName.Trim();
        IsAdmin = isAdmin;
    }
}