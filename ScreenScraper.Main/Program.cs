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

//string[] siteNames = new string[]{"alibaba", "bodega", "ebay", "flight club", "grailed", "stockx", "stadium goods"};
var siteNames = new List<string>();
siteNames.Add("alibaba");
siteNames.Add("bodega");
siteNames.Add("ebay");
siteNames.Add("flight club");
siteNames.Add("grailed");
siteNames.Add("stockx");
siteNames.Add("stadium goods");

Console.WriteLine("Welcome to Data Scraper!");
Console.WriteLine("What would you like to search today?");
Console.WriteLine($"Please enter sites with commas (type 'help' to see the list):");
string userInput = Console.ReadLine();
string inputAsLower = userInput.ToLower();

while (inputAsLower == "help")
{
    Console.WriteLine("alibaba");
    Console.WriteLine("bodega");
    Console.WriteLine("ebay");
    Console.WriteLine("flight club");
    Console.WriteLine("grailed");
    Console.WriteLine("stockx");
    Console.WriteLine("stadium goods");
    userInput = Console.ReadLine();
    inputAsLower = userInput.ToLower();
}

var selectedSites = inputAsLower.Split(",");
var isAllSupported = true;
var unsupportedOptions = new List<string>();

foreach (string item in selectedSites)
{
    var trimmedItem = item.Trim();
    var isSupported = siteNames.Any(m => m == trimmedItem);
    if (isSupported == false)
    {
        isAllSupported = false;
        unsupportedOptions.Add(trimmedItem);
    }
    Console.WriteLine(trimmedItem);

while (isSupported == false)
    {
        isAllSupported = false;
        unsupportedOptions.Add(trimmedItem);
        Console.WriteLine($"Warning: {unsupportedOptions} is not a supported scraper. Do you want to continue with the other selections? Yes or No?");
        string userResponse = Console.ReadLine();
        string responseAsLower = userResponse.ToLower();

        if (responseAsLower == "yes")
        {
            Console.WriteLine(trimmedItem);
        }
        else if (responseAsLower == "no")
        {
            Console.WriteLine("Welcome to Data Scraper!");
            Console.WriteLine("What would you like to search today?");
            Console.WriteLine($"Please enter sites with commas (type 'help' to see the list):");
            Console.WriteLine("Please provide supported sites");
            userInput = Console.ReadLine();
            inputAsLower = userInput.ToLower();
        }
    }

while (userInput != trimmedItem)
    {
        Console.WriteLine($"Warning: your input is invalid. Please try again:");
        Console.WriteLine("Welcome to Data Scraper!");
        Console.WriteLine("What would you like to search today?");
        Console.WriteLine($"Please enter sites with commas (type 'help' to see the list):");
        Console.WriteLine("Please provide supported sites");
        userInput = Console.ReadLine();
        inputAsLower = userInput.ToLower();
    }

}


//foreach (var item in scrapers)
//{
//    item.Run("Nike Air Max 95");
//}
//Kept this at the bottom from the original main test runs - VL 10/19/2023