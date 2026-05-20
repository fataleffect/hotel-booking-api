# hotel-booking-api

For this exercise, I am developing the backend REST API for a hotel booking system using ASP.NET Core and EF Core. This will be deployed to a Azure Web Application using GitHub Actions.

## Assumptions:

### Capacity
There is reference to the fact that rooms cannot be occupied by more people than their capacity. As the capacity is not defined in the spec, I have set it as follows for all hotels:
- Single room = capacity 1
- Double room = capacity 2
- Deluxe room = capacity 3

### Room Distribution
For the purpose of this implementation, I have chosen to distribute the 3 room types equally per hotel. Since each hotel has 6 rooms, each hotel will therefore have 2 single rooms, 2 double rooms and 2 deluxe rooms.

### Booking Allocation
As implied by the spec, a room can potentially be occupied by less people than its capacity (but not more). Since guests cannot change rooms during their stay, the system will ensure availability of specific physical room IDs over a continuous block of dates for each booking.