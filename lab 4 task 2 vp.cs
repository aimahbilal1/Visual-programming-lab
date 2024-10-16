using System;

public class Customer
{
    public string CustomerId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Customer(string customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password)
    {
        CustomerId = customerId;
        LastName = lastName;
        FirstName = firstName;
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
        Phone = phone;
        Email = email;
        Password = password;
    }
    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer ID: {CustomerId}, Name: {FirstName} {LastName}, Address: {Street}, {City}, {State}, {ZipCode}, Phone: {Phone}");
    }
}

public class Reservation
{
    public string ReservationId { get; set; }
    public DateTime ReservationDate { get; set; }
    public Reservation(string reservationId, DateTime reservationDate)
    {
        ReservationId = reservationId;
        ReservationDate = reservationDate;
    }
    public void DisplayReservationInfo()
    {
        Console.WriteLine($"Reservation ID: {ReservationId}, Reservation Date: {ReservationDate}");
    }
}

public class Seat
{
    public string RowNo { get; set; }
    public string SeatNo { get; set; }
    public string Price { get; set; }
    public string Status { get; set; }
    public Seat(string rowNo, string seatNo, string price, string status)
    {
        RowNo = rowNo;
        SeatNo = seatNo;
        Price = price;
        Status = status;
    }
    public void DisplaySeatInfo()
    {
        Console.WriteLine($"Seat: Row {RowNo}, Seat {SeatNo}, Price: {Price}, Status: {Status}");
    }
}

public class Flight
{
    public string FlightId { get; set; }
    public string DepartureTime { get; set; }
    public string ArrivalTime { get; set; }
    public string SeatingCapacity { get; set; }

    public Flight(string flightId, string departureTime, string arrivalTime, string seatingCapacity)
    {
        FlightId = flightId;
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
        SeatingCapacity = seatingCapacity;
    }
    public void DisplayFlightInfo()
    {
        Console.WriteLine($"Flight ID: {FlightId}, Departure: {DepartureTime}, Arrival: {ArrivalTime}, Capacity: {SeatingCapacity}");
    }
}

public class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer("C001", "Smith", "John", "123 Street", "Cityville", "State", "12345", "555-1234", "john@example.com", "password123");
        customer1.DisplayCustomerInfo();

        Reservation reservation1 = new Reservation("R001", DateTime.Now);
        reservation1.DisplayReservationInfo();

        Seat seat1 = new Seat("12", "A", "$100", "Reserved");
        seat1.DisplaySeatInfo();

        Flight flight1 = new Flight("F001", "10:00 AM", "12:00 PM", "180");
        flight1.DisplayFlightInfo();
    }
}

