namespace DesignPatterns.Behavioral.Mediator;

public sealed class AirTrafficControlTower : IAirTrafficControl
{
    private readonly Runway _runway;
    private readonly Dictionary<string, Aircraft> _aircraft =
        new(StringComparer.OrdinalIgnoreCase);

    private readonly Queue<(Aircraft aircraft, string action)> _queue = new();
    private bool _runwayBusy = false;

    public AirTrafficControlTower(Runway runway)
        => _runway = runway;

    public void Register(Aircraft aircraft)
    {
        _aircraft[aircraft.CallSign] = aircraft;
        Console.WriteLine($"[TOWER] Registered aircraft {aircraft.CallSign}.");
    }

    public bool RequestLanding(Aircraft aircraft)
        => Request(aircraft, "LAND");

    public bool RequestTakeoff(Aircraft aircraft)
        => Request(aircraft, "TAKEOFF");

    private bool Request(Aircraft aircraft, string action)
    {
        EnsureRegistered(aircraft);

        if (_runwayBusy)
        {
            _queue.Enqueue((aircraft, action));
            return false;
        }

        _runwayBusy = true;
        aircraft.ClearedToUseRunway(action, _runway);
        return true;
    }

    public void NotifyClearOfRunway(Aircraft aircraft)
    {
        EnsureRegistered(aircraft);

        if (_queue.Count == 0)
        {
            _runwayBusy = false;
            Console.WriteLine("[TOWER] Runway is now free.");
            return;
        }

        var (next, action) = _queue.Dequeue();
        Console.WriteLine($"[TOWER] Next in queue: {next.CallSign} for {action}.");

        _runwayBusy = true;
        next.ClearedToUseRunway(action, _runway);
    }

    private void EnsureRegistered(Aircraft aircraft)
    {
        if (!_aircraft.ContainsKey(aircraft.CallSign))
            throw new InvalidOperationException($"Aircraft '{aircraft.CallSign}' is not registered with ATC.");
    }
}