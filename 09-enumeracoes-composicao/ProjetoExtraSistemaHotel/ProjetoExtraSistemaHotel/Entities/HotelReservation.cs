using ProjetoExtraSistemaHotel.Entities.Enums;
using System.Globalization;
using System.Text;

namespace ProjetoExtraSistemaHotel.Entities
{
    internal class HotelReservation
    {
        public DateTime Moment { get; set; }
        public ReservationStatus Status { get; set; }
        public Guest Guest { get; set; }
        public List<RoomReservation> RoomReservations { get; set; } = new List<RoomReservation>();

        public HotelReservation()
        {

        }

        public HotelReservation(DateTime moment, ReservationStatus status, Guest guest)
        {
            Moment = moment;
            Status = status;
            Guest = guest;
        }

        public void AddRoom(RoomReservation room)
        {
            RoomReservations.Add(room);
        }

        public void RemoveRoom(RoomReservation room)
        {
            RoomReservations.Remove(room);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (RoomReservation item in RoomReservations)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Reservation Moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            stringBuilder.AppendLine($"Reservation Status: {Status}");
            stringBuilder.AppendLine($"Guest: {Guest}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Reserved Rooms:");
            foreach (RoomReservation item in RoomReservations)
            {
                stringBuilder.AppendLine(item.ToString());   
            }
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Total Price: ${Total().ToString("F2",CultureInfo.InvariantCulture)}");
            return stringBuilder.ToString();
        }
    }
}
