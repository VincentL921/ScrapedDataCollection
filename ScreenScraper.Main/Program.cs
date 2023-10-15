using ScreenScraper.Core;
using ScreenScraper.Ebay;
using ScreenScraper.Grailed;

var scrapers = new List<IScraper>();
scrapers.Add(new EbayScraper());
scrapers.Add(new GrailedScraper());

foreach (var item in scrapers)
{
    item.Run("Kith Hoodie");
}