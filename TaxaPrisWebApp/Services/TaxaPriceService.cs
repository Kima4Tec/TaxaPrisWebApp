using TaxaPrisWebApp.Models;
using TaxaPrisWebApp.Services;

public class TaxaPriceService
{
    private readonly TaxaService _taxaService;

    public TaxaPriceService(TaxaService taxaService)
    {
        _taxaService = taxaService;
    }

    public List<TaxaPriceData> GetAllPrices()
    {
        return _taxaService.GetJsonData();
    }

    public string GetKoerselValue(List<TaxaPriceData> allPrice, int carId, string key)
    {
        var car = allPrice?.FirstOrDefault(c => c.Id == carId);
        return car?.Koersel != null && car.Koersel.TryGetValue(key, out var value) ? value : "N/A";
    }

    public string GetTillaegValue(TaxaPriceData currentTaxa, string key)
    {
        return currentTaxa?.Tillaeg != null && currentTaxa.Tillaeg.TryGetValue(key, out var value) ? value : "N/A";
    }

    public int GetTillaegValueAsInt(List<TaxaPriceData> allPrice, int id, string key)
    {
        var item = allPrice?.FirstOrDefault(m => m.Id == id);
        if (item?.Tillaeg != null && item.Tillaeg.TryGetValue(key, out var value))
        {
            return int.TryParse(value, out int result) ? result : 0;
        }
        return 0;
    }

    public int GetKoerselValueAsInt(List<TaxaPriceData> allPrice, int id, string key)
    {
        var car = allPrice?.FirstOrDefault(c => c.Id == id);
        if (car?.Koersel != null && car.Koersel.TryGetValue(key, out var value))
        {
            return int.TryParse(value, out int result) ? result : 0;
        }
        return 0;
    }

    public decimal GetKoerselValueAsDecimal(List<TaxaPriceData> allPrice, int id, string key)
    {
        var car = allPrice?.FirstOrDefault(c => c.Id == id);
        if (car?.Koersel != null && car.Koersel.TryGetValue(key, out var value))
        {
            return decimal.TryParse(value, out decimal result) ? result : 0m;
        }
        return 0m;
    }

    ////For view prices
    //public string GetKoerselValue(List<TaxaPriceData> allPrice, int carId, string key)
    //{
    //    var car =allPrice?.FirstOrDefault(c => c.Id == carId);
    //    return car?.Koersel != null && car.Koersel.TryGetValue(key, out var value) ? value : "N/A";
    //}
    //public string GetTillaegValue(TaxaPriceData currentTaxa, string key)
    //{
    //    return currentTaxa?.Tillaeg != null && currentTaxa.Tillaeg.TryGetValue(key, out var value) ? value : "N/A";
    //}
}
