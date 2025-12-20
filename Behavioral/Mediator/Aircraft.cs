namespace DesignPatterns.Behavioral.Mediator;

public sealed class Aircraft
{
    private readonly IAirTrafficControl _atc;
    public string CallSign { get; }
    public bool IsOnGround { get; private set; }

    public Aircraft(string callSign, IAirTrafficControl atc, bool isOnGround)
    {
        _atc = atc;
        CallSign = callSign.Trim().ToUpperInvariant();
        IsOnGround = isOnGround;
    }

    public void RequestLanding()
    {
        if (IsOnGround)
        {
            Console.WriteLine($"{CallSign}: Already on ground, landing not needed.");
            return;
        }

        bool granted = _atc.RequestLanding(this);
        Console.WriteLine(granted
            ? $"{CallSign}: Landing clearance granted."
            : $"{CallSign}: Landing request queued (runway busy).");
    }

    public void RequestTakeoff()
    {
        if (!IsOnGround)
        {
            Console.WriteLine($"{CallSign}: Already airborne, takeoff not needed.");
            return;
        }

        bool granted = _atc.RequestTakeoff(this);
        Console.WriteLine(granted
            ? $"{CallSign}: Takeoff clearance granted."
            : $"{CallSign}: Takeoff request queued (runway busy).");
    }

    // Called by tower when it's truly cleared to use runway
    internal void ClearedToUseRunway(string action, Runway runway)
    {
        Console.WriteLine($"[TOWER] {CallSign} cleared for {action} on runway {runway}.");
    }

    // Called when the aircraft finishes landing/takeoff and runway becomes free
    public void ClearRunwayAfter(string action)
    {
        // Update state: after landing -> on ground, after takeoff -> airborne
        IsOnGround = action == "LAND";
        Console.WriteLine($"{CallSign}: Completed {action}, runway clear.");

        _atc.NotifyClearOfRunway(this);
    }
}