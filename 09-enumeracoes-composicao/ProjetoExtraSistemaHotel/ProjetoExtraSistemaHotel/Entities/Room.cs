using ProjetoExtraSistemaHotel.Entities.Enums;
using System.Globalization;

namespace ProjetoExtraSistemaHotel.Entities
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public RoomType Type { get; set; }
        public double DailyPrice { get; set; }

        public Room()
        {

        }

        public Room(int roomNumber, RoomType type, double dailyPrice)
        {
            RoomNumber = roomNumber;
            Type = type;
            DailyPrice = dailyPrice;
        }

        public override string ToString()
        {
            return $"Room Number: {RoomNumber}, Room Type: {Type}, Daily Price: ${DailyPrice.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
