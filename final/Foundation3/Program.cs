using System;

// Address class to store address details
class Address
{
    private string street;
    private string city;
    private string country;

    public Address(string street, string city, string country)
    {
        this.street = street;
        this.city = city;
        this.country = country;
    }

    public override string ToString()
    {
        return $"{street}, {city}, {country}";
    }
}

// Base Event class
class Event
{
    private string title;
    private string description;
    private DateTime date;
    private DateTime time;
    private Address address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}

// Lecture class
class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}

// Reception class
class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

// OutdoorGathering class
class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Cityville", "Countryland");
        Address address2 = new Address("456 Elm St", "Townsville", "Countryland");

        Lecture lecture = new Lecture("Interesting Topic", "Join us for an insightful talk", DateTime.Now, DateTime.Now, address1, "John Doe", 50);
        Reception reception = new Reception("Networking Event", "Come mingle with professionals", DateTime.Now, DateTime.Now, address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Family Picnic", "Enjoy a day outdoors with games and food", DateTime.Now, DateTime.Now, address2, "Sunny skies");

        Console.WriteLine("Lecture Marketing Messages:");
        Console.WriteLine("Standard Details:\n" + lecture.GetStandardDetails());
        Console.WriteLine("Full Details:\n" + lecture.GetFullDetails());
        Console.WriteLine("Short Description:\n" + lecture.GetShortDescription());

        Console.WriteLine("\nReception Marketing Messages:");
        Console.WriteLine("Standard Details:\n" + reception.GetStandardDetails());
        Console.WriteLine("Full Details:\n" + reception.GetFullDetails());
        Console.WriteLine("Short Description:\n" + reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Marketing Messages:");
        Console.WriteLine("Standard Details:\n" + gathering.GetStandardDetails());
        Console.WriteLine("Full Details:\n" + gathering.GetFullDetails());
        Console.WriteLine("Short Description:\n" + gathering.GetShortDescription());
    }
}