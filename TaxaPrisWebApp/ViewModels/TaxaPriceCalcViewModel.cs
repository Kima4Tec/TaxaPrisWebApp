using TaxaPrisWebApp.Models;

namespace TaxaPrisWebApp.ViewModels 
{ 
public class TaxaPriceCalcViewModel
{
    public List<TaxaPriceData>? AllPrice { get; set; }
    public TaxaPriceData CurrentTaxa { get; set; }
    public string ShowTimeTitle { get; set; } = "Tidspunkt";
    public string ShowPassengerTitle { get; set; } = "Antal Passagerer";
    public string? Message { get; set; }
    public string? ConvertedCarMessage { get; set; }
    public string? SelectedTime { get; set; }
    public int SelectedPassenger { get; set; }
    public int MoreThanFour { get; set; }
    public int ConvertedBikePrice { get; set; }
    public int ConvertedUpPrice { get; set; }
    public int AirportPrice { get; set; }
    public int LiftPrice { get; set; }
    public int OeresundPrice { get; set; }
    public int StorebaeltPrice { get; set; }
    public string? SelectedData { get; set; }
    public string? DistanceValue { get; set; }
    public int SelectedId { get; set; }
    public string? SelectedOptionsText { get; set; }
    public List<CheckBoxOption> Options { get; set; } = new List<CheckBoxOption>
    {
        new CheckBoxOption { IsChecked = false, Label = "Cykel" },
        new CheckBoxOption { IsChecked = false, Label = "Opbæring" },
        new CheckBoxOption { IsChecked = false, Label = "Lufthavn" },
        new CheckBoxOption { IsChecked = false, Label = "Liftvogn" },
        new CheckBoxOption { IsChecked = false, Label = "Øresund" },
        new CheckBoxOption { IsChecked = false, Label = "Storebælt" }
    };
}
}