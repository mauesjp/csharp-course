using ProjetoSistemaPedido.Entities.Enums;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace ProjetoSistemaPedido.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Order Moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            stringBuilder.AppendLine($"Order Status: {Status}");
            stringBuilder.AppendLine($"Client: {Client}");
            stringBuilder.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.AppendLine($"Total Price: ${Total().ToString("F2",CultureInfo.InvariantCulture)}");
            return stringBuilder.ToString();
        }
    }
}
