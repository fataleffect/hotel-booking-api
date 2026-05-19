namespace HotelBookingApi.Domain.Entities;

public class Booking
{
    public int Id { get; set; }
    public int RoomId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int GuestCount { get; set; }
    public string BookingReference { get; set; } = string.Empty;
    // Navigation
    public Room Room { get; set; } = null!;
}