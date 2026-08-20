namespace ExercicioGameLibrary {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many games will be added? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Game> games = new List<Game>();

            for(int i = 1; i <= n; i++) {

                Console.WriteLine($"Game #{i}:");
                Console.Write("Game ID: ");
                int id = int.Parse(Console.ReadLine());

                while(games.Any(x => x.Id == id)) {
                    Console.WriteLine("This id already exists!");
                    Console.Write("Please enter another id: ");
                    id = int.Parse(Console.ReadLine());
                }
                Console.Write("Game Title: ");
                string title = Console.ReadLine();

                while(games.Any(x => x.Title == title)) {
                    Console.WriteLine("This title already exists!");
                    Console.Write("Please enter another title: ");
                    title = Console.ReadLine();
                }
                Console.Write("Game Genre: ");
                string genre = Console.ReadLine();
                Console.Write("Game Price: ");
                double price = double.Parse(Console.ReadLine());

                games.Add(new Game(id, title, genre, price));
                Console.WriteLine("=============================================================");
            }

            int menuOption = 0;
            
            while(menuOption != 5) {

                Console.WriteLine("===== GAME LIBRARY =====");
                Console.WriteLine("1 - List all games");
                Console.WriteLine("2 - Search game");
                Console.WriteLine("3 - Remove game");
                Console.WriteLine("4 - Show games by genre");
                Console.WriteLine("5 - Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                menuOption = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("=============================================================");
                Console.WriteLine();

                if (menuOption == 1) {
                    foreach (Game item in games) {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();

                }
                else if (menuOption == 2) {
                    Console.Write("Enter the game ID: ");
                    int findGame = int.Parse(Console.ReadLine());
                    Game gamefound = games.Find(x => x.Id == findGame);

                    if (gamefound != null) {
                        Console.WriteLine("Game found:");
                        Console.WriteLine(gamefound);
                        Console.WriteLine();
                    }
                    else {
                        Console.WriteLine("This id does not exist!");
                        Console.WriteLine();
                    }
                }
                else if (menuOption == 3) {
                    Console.Write("Enter the ID of the game to be removed: ");
                    int removeGame = int.Parse(Console.ReadLine());

                    Game gameToBeRemoved = games.Find(x => x.Id == removeGame);

                    if (gameToBeRemoved != null) {
                        games.Remove(gameToBeRemoved);
                        Console.WriteLine("Game removed successfully!");
                    }
                    else {
                        Console.WriteLine("This id does not exist!");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Updated List:");

                    foreach (Game item in games) {

                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                }
                else if (menuOption == 4) {

                    Console.Write("Enter the desired genre: ");
                    string findGenre = Console.ReadLine();

                    List<Game> gamesFiltered = games.FindAll(x => x.Genre == findGenre);

                    Console.WriteLine();
                    Console.WriteLine("Filtered List:");

                    if (gamesFiltered.Count > 0) {
                        foreach (Game item in gamesFiltered) {
                            Console.WriteLine(item);
                        }
                    }
                    else {
                        Console.WriteLine("No games found in this genre.");
                    }

                    Console.WriteLine();
                }
            }

        }
    }
}
