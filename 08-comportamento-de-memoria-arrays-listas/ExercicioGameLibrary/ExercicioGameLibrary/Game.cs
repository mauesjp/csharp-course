using System.Globalization;

namespace ExercicioGameLibrary {
    internal class Game {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Price { get; private set; }

        public Game(int id, string title, string genre, double price) {

            Id = id;
            Title = title;
            Genre = genre;
            Price = price;
        }

        public override string ToString() {
            return $"{Id},{Title},{Genre},{Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
