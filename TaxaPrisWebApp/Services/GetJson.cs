using Newtonsoft.Json;
using TaxaPrisWebApp.Model;

namespace TaxaPrisWebApp.Services
{
    public class GetJson
    {
        public List<TaxaPriceData> GetJsonData()
        {
            //Name of json-file into variable
            string jsonFilePath = "wwwroot/Taxa/Taxapris.json";
            string json;

                // Read JSON-data from file and add to the variable json
                json = File.ReadAllText(jsonFilePath);

            List<TaxaPriceData> allData;

            // Deserialise JSON-data to a list of QuestionData-objects
            allData = JsonConvert.DeserializeObject<List<TaxaPriceData>>(json);

            return allData;
        }
    }
}
