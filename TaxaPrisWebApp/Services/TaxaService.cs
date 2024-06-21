using Newtonsoft.Json;
using TaxaPrisWebApp.Models;

namespace TaxaPrisWebApp.Services
{
    public class TaxaService
    {
        public List<TaxaPriceData>? GetJsonData()
        {
            //Name of json-file into variable
            string jsonFilePath = "wwwroot/Taxa/Taxapris.json";
            string json;

            try
            {
                // Read JSON-data from file and add to the variable json
                json = File.ReadAllText(jsonFilePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Fejl: Filen '{jsonFilePath}' blev ikke fundet.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl under læsning af filen: {ex.Message}");
                return null;
            }

            List<TaxaPriceData>? allData;

            // Deserialise JSON-data to a list of QuestionData-objects
            allData = JsonConvert.DeserializeObject<List<TaxaPriceData>>(json);

            return allData;
        }
    }
}
