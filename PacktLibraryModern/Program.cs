using  Packt.Shared;
using static System.Console;

object[] passengers = {
 new FirstClassPassenger { AirMiles = 1_419 },
 new FirstClassPassenger { AirMiles = 16_562 },
 new BusinessClassPassenger(),
 new CoachClassPassenger { CarryOnKG = 25.7 },
 new CoachClassPassenger { CarryOnKG = 0 },
};

foreach (object passenger in passengers)
{
 decimal flightCost = passenger switch
 {
 FirstClassPassenger p => p.AirMiles switch
 {
 > 35000 => 1500M,
 > 15000 => 1750M,
 _ => 2000M
 },
 BusinessClassPassenger _ => 1000M,
 CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
 CoachClassPassenger _ => 650M,
 _ => 800M
};
 WriteLine($"Flight costs {flightCost:C} for {passenger}");
 WriteLine($"Output Praktikum 3 dari <La Ode Ridho>");
}