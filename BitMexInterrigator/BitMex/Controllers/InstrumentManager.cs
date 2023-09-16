using BitMexInterrigator.BitMex.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BitMexInterrigator.BitMex.Controllers
{
    public class InstrumentManager
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseURI = "https://www.bitmex.com/api/v1/";

        public InstrumentManager()
        {
            Debug.WriteLine("InstrumentManager Instantiated");

            httpClient.BaseAddress = new Uri(baseURI);

        }

        public async Task<List<Instrument>> getTradeableInstrumentsAsync()
        {
            Debug.WriteLine("Getting Tradeable Instruments");

            List<Instrument> instruments = new List<Instrument>();

            try
            {
                // Send an HTTP GET request to the BitMEX API
                var response = await httpClient.GetAsync("instrument/active");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    var content = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response into a list of Instrument objects
                    instruments = JsonSerializer.Deserialize<List<Instrument>>(content);


                }
                else
                {
                    Debug.WriteLine($"HTTP request failed with status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}");
            }
            return instruments;
        }
    }
}
