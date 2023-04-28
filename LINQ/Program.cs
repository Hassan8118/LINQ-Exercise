namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<string> videoGames = new List<string>() { "Rocket League", "Call Of Duty", "Fifa"};
            videoGames.Add("Fortnite");
            videoGames.Add("GTA RP");

            var sortedGames = videoGames.OrderByDescending(name => name.Length);

            foreach (var games in sortedGames)
            {
                Console.WriteLine(games);
            }
        }
    }
}
