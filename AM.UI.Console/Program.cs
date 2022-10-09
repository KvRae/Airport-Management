﻿// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System.Numerics;
using Plane = AM.ApplicationCore.Domain.Plane;

//Plane plane = new Plane();
//plane.PlaneType = PlaneType.Airbus;
//plane.Capacity = 200;
//plane.ManufactureDate = new DateTime(2018, 11, 10);

//Plane plane2 = new Plane(PlaneType.Boing, 300, DateTime.Now);
Plane plane3 = new Plane { PlaneType = PlaneType.Airbus, Capacity = 150, ManufactureDate = new DateTime(2015, 02, 03) };

Console.WriteLine("************************************ Testing Signature Polymorphisme ****************************** ");
Passenger p1 = new Passenger { FirstName = "steave", LastName = "jobs", EmailAddress = "steeve.jobs@gmail.com", BirthDate = new DateTime(1955, 01, 01) };
Console.WriteLine("la méthode Checkpassenger");
Console.WriteLine(p1.CheckProfile("Steave", "Jobs"));
Console.WriteLine(p1.CheckProfile("steave", "jobs", "steeve.jobs@gmail"));

Console.WriteLine("************************************ Testing Inheritance Polymorphisme ****************************** ");
Staff s1 = new Staff { FirstName = "Bill", LastName = "Gates", EmailAddress = "Bill.gates@gmail.com", BirthDate = new DateTime(1945, 01, 01), EmployementDate = new DateTime(1990, 01, 01), Salary = 99999 };
Traveller t1 = new Traveller { FirstName = "Mark", LastName = "Zuckerburg", EmailAddress = "Mark.Zuckerburg@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "Some troubles", Nationality = "American" };
p1.PassengerType();
s1.PassengerType();
t1.PassengerType();

Console.WriteLine("************************************ Testing Services  ****************************** ");
ServiceFlight sf = new ServiceFlight();

sf.Flights = TestData.listFlights;

Console.WriteLine("************************************ GetFlightDates (string destination)  ****************************** ");
Console.WriteLine("Flight dates to Madrid");
foreach (var item in sf.GetFlightDates("Madrid"))
    Console.WriteLine(item);
Console.WriteLine("************************************ GetFlights(string filterType, string filterValue)  ****************************** ");
sf.GetFlights("Destination", "Paris");
Console.WriteLine("************************************ ShowFlightDetails(Plane plane)  ****************************** ");
sf.ShowFlightDetails(TestData.Airbusplane);
Console.WriteLine("************************************ ProgrammedFlightNumber(DateTime startDate)  ****************************** ");
Console.WriteLine("Number of programmed flights in 01/01/2022 week: ");
sf.ProgrammedFlightNumber(new DateTime(2022, 01, 01));
Console.WriteLine("************************************ DurationAverage(string destination) ****************************** ");
Console.WriteLine("Duration average of flights to Madrid: " + sf.DurationAverage("Madrid"));
Console.WriteLine("************************************ OrderedDurationFlights()  ****************************** ");
foreach (var item in sf.OrderedDurationFlights())
    Console.WriteLine(item);
Console.WriteLine("************************************ SeniorTravellers(Flight flight) ****************************** ");
foreach (var item in sf.SeniorTravellers(TestData.flight1))
    Console.WriteLine(item);
Console.WriteLine("************************************ DestinationGroupedFlights()  ****************************** ");
sf.DestinationGroupedFlights();

Console.WriteLine("************************************ Testing Delegates  ****************************** ");

sf.FlightDetailsDel(TestData.BoingPlane);
Console.WriteLine("Average duration of flight To Paris; " + sf.DurationAverageDel("Paris"));

Console.WriteLine("************************************ Testing Extension methods  ****************************** ");
p1.UpperFullName();
Console.WriteLine("First Name: " + p1.FirstName + " Last Name: " + p1.LastName);
