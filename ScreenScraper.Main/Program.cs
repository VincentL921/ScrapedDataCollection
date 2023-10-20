using ScreenScraper.Core;
using ScreenScraper.Ebay;
using ScreenScraper.Grailed;
using ScreenScraper.FlightClub;
using ScreenScraper.Bodega;

var scrapers = new List<IScraper>();
scrapers.Add(new EbayScraper());
scrapers.Add(new GrailedScraper());
scrapers.Add(new FlightClubScraper());
scrapers.Add(new BodegaScraper());

Console.WriteLine("Welcome to Data Scraper!");
Console.WriteLine("What would you like to search today?");
Console.WriteLine($"Please enter sites with commas (type 'help' to see the list):");
string userInput = Console.ReadLine();

while (userInput == "help")
{
    Console.WriteLine("alibaba");
    Console.WriteLine("bodega");
    Console.WriteLine("ebay");
    Console.WriteLine("flight club");
    Console.WriteLine("grailed");
    Console.WriteLine("stockx");
    Console.WriteLine("stadium goods");
    userInput = Console.ReadLine();
}



//foreach (var item in scrapers)
//{
//    item.Run("Nike Air Max 95");
//}
//Kept this at the bottom from the original main test runs - VL 10/19/2023