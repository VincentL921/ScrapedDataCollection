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


foreach (var item in scrapers)
{
    item.Run("Nike Air Max 95");
}