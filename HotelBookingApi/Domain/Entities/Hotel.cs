namespace HotelBookingApi.Domain.Entities;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    // Navigation
    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}