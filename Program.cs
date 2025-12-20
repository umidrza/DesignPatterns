using DesignPatterns.Behavioral.Mediator;

var atc = new AirTrafficControlTower(new Runway("27L"));

var a1 = new Aircraft("AZA101", atc, isOnGround: false);
var a2 = new Aircraft("TUR202", atc, isOnGround: true);
var a3 = new Aircraft("BAW303", atc, isOnGround: false);

atc.Register(a1);
atc.Register(a2);
atc.Register(a3);

Console.WriteLine();

a1.RequestLanding();
a2.RequestTakeoff();
a3.RequestLanding();

Console.WriteLine();

a1.ClearRunwayAfter("LAND");

Console.WriteLine();

a2.ClearRunwayAfter("TAKEOFF");

Console.WriteLine();

a3.ClearRunwayAfter("LAND");
