using ProjetoExtraSistemaHotel.Entities;
using ProjetoExtraSistemaHotel.Entities.Enums;
using System.Globalization;

namespace ProjetoExtraSistemaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter guest data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Guest guest = new Guest(name, email, birthDate);
            
            Console.WriteLine("Enter reservation data:");
            Console.Write("Status: ");
            ReservationStatus status = Enum.Parse<ReservationStatus>(Console.ReadLine());
            Console.Write("How many rooms to reserve? ");
            int numberOfRooms = int.Parse(Console.ReadLine());
            Console.WriteLine();

            HotelReservation hotelReservation = new HotelReservation(DateTime.Now, status, guest);

            for (int i = 1; i <= numberOfRooms; i++)
            {
                Console.WriteLine($"Enter room #{i} data:");
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Room type: ");
                RoomType roomType = Enum.Parse<RoomType>(Console.ReadLine());
                Console.Write("Daily price: ");
                double dailyPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("How many days? ");
                int days = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Room rooms = new Room(roomNumber, roomType, dailyPrice);
                RoomReservation roomReservation = new RoomReservation(days, rooms);

                hotelReservation.AddRoom(roomReservation);
            }

            Console.WriteLine("=======================RESERVATION SUMMARY=======================");
            Console.WriteLine();
            Console.WriteLine(hotelReservation);
        }
    }
}
