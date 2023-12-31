﻿using BitMexInterrigator.BitMex.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BitMexInterrogator.BitMex.API
{
    public class GetTradeableInstrumentsAPI
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseURI = "https://www.bitmex.com/api/v1/";

        public GetTradeableInstrumentsAPI()
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
                var response = await httpClient.GetAsync("instrument/active");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

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
