using BitMexInterrigator.BitMex.Classes;
using BitMexInterrogator.BitMex.API;

namespace BitMexInterrigator.BitMex.Controllers
{
    public class InstrumentManagerController
    {
        private static GetTradeableInstrumentsAPI tradeableInstrumentsAPI = new GetTradeableInstrumentsAPI();

        public static async Task<List<Instrument>>  GetTradeableInstruments()
        {
            return await tradeableInstrumentsAPI.getTradeableInstrumentsAsync();
        }
    }
}
