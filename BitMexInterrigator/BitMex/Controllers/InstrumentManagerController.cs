using BitMexInterrigator.BitMex.Classes;
using BitMexInterrogator.BitMex.API;

namespace BitMexInterrigator.BitMex.Controllers
{
    public class InstrumentManagerController
    {
        GetTradeableInstrumentsAPI tradeableInstrumentsAPI = new GetTradeableInstrumentsAPI();

        public async Task<List<Instrument>>  GetTradeableInstruments()
        {
            return await tradeableInstrumentsAPI.getTradeableInstrumentsAsync();
        }
    }
}
