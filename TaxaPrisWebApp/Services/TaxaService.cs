using Newtonsoft.Json;

namespace TaxaPrisWebApp.Services
{
    public class TaxaService
    {
        public int? Id { get; set; }
        public string? VognType { get; set; }
        public string? AntalPassagerer { get; set; }
        public string? Tid { get; set; }
        public string? Tidspunkt { get; set; }
        public Dictionary<string, string>? Koersel { get; set; }
        public Dictionary<string, string>? Tillaeg { get; set; }

        public List<TaxaService>? GetJsonData()
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

            List<TaxaService>? allData;

            // Deserialise JSON-data to a list of QuestionData-objects
            allData = JsonConvert.DeserializeObject<List<TaxaService>>(json);

            return allData;
        }
    }
}
