using System.Globalization;

namespace ProjetoExtraSistemaHotel.Entities
{
    internal class RoomReservation
    {
        public int Days { get; set; }
        public double DailyPrice { get; set; }
        public Room Room { get; set; } = new Room();

        public RoomReservation()
        {

        }

        public RoomReservation(int days, Room room)
        {
            Days = days;
            Room = room;
            DailyPrice = Room.DailyPrice;
        }

        public double SubTotal()
        {
            return Days * DailyPrice;
        }

        public override string ToString()
        {
            return $"Room {Room.RoomNumber}, " +
                $"Daily Price: ${DailyPrice.ToString("F2",CultureInfo.InvariantCulture)}, " +
                $"Days: {Days}, " +
                $"Subtotal: ${SubTotal().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
