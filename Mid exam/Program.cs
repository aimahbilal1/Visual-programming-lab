using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class User
{
    private string userId;
    private string name;
    private string phoneNumber;

    public string UserId { get => userId; }
    public string Name { get => name; }
    public string PhoneNumber
    {
        get => phoneNumber;
        set
        {
            if (IsValidPhoneNumber(value))
            {
                phoneNumber = value;
            }
            else
            {
                throw new ArgumentException("Invalid phone number format.");
            }
        }
    }

    public User(string userId, string name, string phoneNumber)
    {
        this.userId = userId;
        this.name = name;
        this.phoneNumber = phoneNumber;
    }

    public void Register()
    {
        Console.WriteLine($"{name} Registered successfully.");
    }

    public void Login()
    {
        Console.WriteLine($"{name} Logged in.");
    }

    public void DisplayProfile()
    {
        Console.WriteLine($"User  ID: {userId}, Name: {name}, Phone: {phoneNumber}");
    }

    private bool IsValidPhoneNumber(string phoneNumber)
    {
        return Regex.IsMatch(phoneNumber, @"^\d{11}$");
    }
}

public class Rider : User
{
    private List<Trip> rideHistory;

    public List<Trip> RideHistory => rideHistory;

    public Rider(string userId, string name, string phoneNumber) : base(userId, name, phoneNumber)
    {
        rideHistory = new List<Trip>();
    }

    public void requestRide(RideSharingSystem system, string startLocation, string destination)
    {
        system.RequestRide(this, startLocation, destination);
    }

    public void ViewRideHistory()
    {
        if (rideHistory.Count == 0)
        {
            Console.WriteLine("No ride history.");
            return;
        }

        foreach (var trip in rideHistory)
        {
            trip.DisplayTripDetails();
        }
    }
}

public class Driver : User
{
    private string driverId;
    private bool isAvailable;
    private List<Trip> tripHistory;
    private string vehicleDetails;

    public string DriverId { get => driverId; }
    public bool IsAvailable { get => isAvailable; }

    public Driver(string userId, string name, string phoneNumber, string driverId, string vehicleDetails) : base(userId, name, phoneNumber)
    {
        this.driverId = driverId;
        this.vehicleDetails = vehicleDetails;
        tripHistory = new List<Trip>();
        isAvailable = true;
    }

    public void AcceptRide(Trip trip)
    {
        trip.StartTrip();
        tripHistory.Add(trip);
        isAvailable = false;
    }

    public void ViewTripHistory()
    {
        if (tripHistory.Count == 0)
        {
            Console.WriteLine("No Trip History.");
            return;
        }

        foreach (var trip in tripHistory)
        {
            trip.DisplayTripDetails();
        }
    }

    public void ToggleAvailability()
    {
        isAvailable = !isAvailable;
        Console.WriteLine($"{Name} is now {(isAvailable ? "Available" : "Not Available")} for Rides.");
    }

    internal void CompleteTrip(Trip trip)
    {
        throw new NotImplementedException();
    }
}

public class Trip
{
    private string tripId;
    private string riderName;
    private string driverName;
    private string startLocation;
    private string destination;
    private double fare;
    private string status;

    public string TripId { get => tripId; }
    public string Status { get => status; }

    public Trip(string tripId, string riderName, string driverName, string startLocation, string destination)
    {
        this.tripId = tripId;
        this.riderName = riderName;
        this.driverName = driverName;
        this.startLocation = startLocation;
        this.destination = destination;
        this.status = "Pending";
    }

    public double CalculateFare()
    {
        fare = 100.0;
        return fare;
    }

    public void StartTrip()
    {
        status = "In Progress";
        Console.WriteLine($"Trip {tripId} started from {startLocation} to {destination}.");
    }

    public void EndTrip()
    {
        status = "Completed";
        Console.WriteLine($"Trip {tripId} completed. Fare: {fare}");
    }

    public void DisplayTripDetails()
    {
        Console.WriteLine($"Trip ID: {tripId}. Rider Name: {riderName}. Driver Name: {driverName}. Start Location: {startLocation}. Destination: {destination}.");
    }
}
public class RideSharingSystem
{
    private readonly List<Rider> registerRiders;
    public List<Rider> RegisterRiders => registerRiders;

    private List<Driver> registerDrivers;
    public List<Driver> RegisterDrivers => registerDrivers;
    private List<Trip> availableTrips;

    public List<Trip> AvailableTrips => availableTrips;
    public RideSharingSystem()
    {
        registerRiders = new List<Rider>();
        registerDrivers = new List<Driver>();
        availableTrips = new List<Trip>();
    }
    public void RegisterUser(string userId, string name, string phoneNumber, string userType, string driverId = "", string vehicleDetails = "")
    {
        if (userType == "Rider")
        {
            Rider rider = new Rider(userId, name, phoneNumber);
            registerRiders.Add(rider);
            rider.Register();
        }
        else if (userType == "Driver")
        {
            Driver driver = new Driver(userId, name, phoneNumber, driverId, vehicleDetails);
            registerDrivers.Add(driver);
            driver.Register();
        }
    }

    public void RequestRide(Rider rider, string startLocation, string destination)
    {
        Trip trip = new Trip(Guid.NewGuid().ToString(), rider.Name, "", startLocation, destination);
        availableTrips.Add(trip);
        Console.WriteLine($"Ride requested from {startLocation} to {destination}.");
    }

    public void FindAvailableDriver()
    {
        foreach (var driver in registerDrivers)
        {
            if (driver.IsAvailable)
            {
                Console.WriteLine($"Available driver: {driver.Name}");
                return;
            }
        }
        Console.WriteLine("No available drivers.");
    }

    public void CompleteTrip(Trip trip)
    {
        trip.EndTrip();
        availableTrips.Remove(trip);
    }

    public void DisplayAllTrips()
    {
        if (availableTrips.Count == 0)
        {
            Console.WriteLine("No trips available.");
            return;
        }

        foreach (var trip in availableTrips)
        {
            trip.DisplayTripDetails();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        RideSharingSystem system = new RideSharingSystem();

        while (true)
        {
            Console.WriteLine("Ride Sharing System");
            Console.WriteLine("1. Register as Rider");
            Console.WriteLine("2. Register as Driver");
            Console.WriteLine("3. Request a Ride");
            Console.WriteLine("4. Accept a Ride");
            Console.WriteLine("5. Complete a Trip");
            Console.WriteLine("6. View Ride History (Rider)");
            Console.WriteLine("7. View Trip History (Driver)");
            Console.WriteLine("8. Display All Trips");
            Console.WriteLine("9. Exit");

            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Enter user ID: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string riderUserId = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Write("Enter name: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string riderName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Write("Enter phone number: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string riderPhoneNumber = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
                    system.RegisterUser(riderUserId, riderName, riderPhoneNumber, "Rider");
#pragma warning restore CS8604 // Possible null reference argument.
                    break;
                case 2:
                    Console.Write("Enter user ID: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string driverUserId = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Write("Enter name: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string driverName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Write("Enter phone number: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string driverPhoneNumber = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Write("Enter driver ID: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string driverId = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Write("Enter vehicle details: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string vehicleDetails = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
                    system.RegisterUser(driverUserId, driverName, driverPhoneNumber, "Driver", driverId, vehicleDetails);
#pragma warning restore CS8604 // Possible null reference argument.
                    break;
                case 3:
                    Console.Write("Enter start location: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string startLocation = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Write("Enter destination: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string destination = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Rider rider = system.RegisterRiders[0];
#pragma warning disable CS8604 // Possible null reference argument.
                    system.RequestRide(rider, startLocation, destination);
#pragma warning restore CS8604 // Possible null reference argument.
                    break;
                case 4:
                    Trip trip = system.AvailableTrips[0];
                    Driver driver = system.RegisterDrivers[0];
                    driver.AcceptRide(trip);
                    break;
                case 5:
                    trip = system.AvailableTrips[0];
                    driver = system.RegisterDrivers[0];
                    driver.CompleteTrip(trip);
                    system.CompleteTrip(trip);
                    break;
                case 6:
                    rider = system.RegisterRiders[0];
                    rider.ViewRideHistory();
                    break;
                case 7:
                    driver = system.RegisterDrivers[0];
                    driver.ViewTripHistory();
                    break;
                case 8:
                    system.DisplayAllTrips();
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}

