namespace DesignPatterns.Structural.Decorator.Decorators;

public sealed class RetryDecorator : NotificationSenderDecorator
{
    private readonly int _maxRetries;

    public RetryDecorator(INotificationSender inner, int maxRetries) : base(inner)
    {
        _maxRetries = maxRetries;
    }

    public override void Send(string recipient, string message)
    {
        var attempts = 0;

        while (true)
        {
            try
            {
                attempts++;
                Inner.Send(recipient, message);
                return;
            }
            catch (Exception) when (attempts < _maxRetries)
            {
                Console.WriteLine($"[RETRY] Attempt {attempts} failed, retrying...");
            }
        }
    }
}