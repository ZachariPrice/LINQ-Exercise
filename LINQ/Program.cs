// using C34PracticeLinqExercise;



List<string> xboxExclusiveGames = new List<string>() { "Halo Series", "Apex Legends", "NBA 2K Series" };

xboxExclusiveGames.Add("Ninja Gaiden");
xboxExclusiveGames.Add("Rocket League");

var videoGames = xboxExclusiveGames.OrderByDescending(name => name.Length);

foreach (var games in videoGames)
{
    Console.WriteLine(games);
}