namespace DesignPatterns.Behavioral.Mediator;

public interface IAirTrafficControl
{
    void Register(Aircraft aircraft);

    bool RequestLanding(Aircraft aircraft);

    bool RequestTakeoff(Aircraft aircraft);

    void NotifyClearOfRunway(Aircraft aircraft);
}