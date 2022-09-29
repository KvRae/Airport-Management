// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");

Plane plane = new Plane();
plane.Capacity = 100;
plane.PlaneType = PlaneType.Boeing;
plane.ManufactureDate = DateTime.Now;
Console.WriteLine(plane);

Plane plane3 = new Plane() { Capacity = 100,ManufactureDate=DateTime.Now };

Passenger passenger1 = new Passenger {FirstName="mohamed",LastName="kalech",EmailAddress="kalech@gmail.com"};
bool b1 = passenger1.CheckProfile("mohamed", "kalech");
bool b2 = passenger1.CheckProfile("mohamed", "kalech", "sqdqs");
Console.WriteLine(b1);
Console.WriteLine(b2);

Staff s1 = new Staff();
Traveller t1 = new Traveller();
passenger1.PassengerType();
s1.PassengerType();
t1.PassengerType();
