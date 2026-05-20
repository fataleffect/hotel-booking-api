namespace HotelBookingApi.Domain.Entities;

public class Room
{
    public int Id { get; set; }
    public int HotelId { get; set; }
    public string RoomNumber { get; set; } = string.Empty;
    public RoomType Type { get; set; }
    public int Capacity => Type switch
    {
        RoomType.Single => 1,
        RoomType.Double => 2,
        RoomType.Deluxe => 4,
        _ => throw new ArgumentOutOfRangeException(nameof(Type), "Unknown room type found.")
    };
    // Navigation
    public Hotel Hotel { get; set; } = null!;
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}

public enum RoomType
{
    Single = 1,
    Double = 2,
    Deluxe = 3
}