using BitMexInterrigator.BitMex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMexInterrigator.BitMex.Classes
{
    public class Instrument : IInstrument
    {
        public string symbol { get; set; }
        public string rootSymbol { get; set; }
        public string state { get; set; }
        public string typ { get; set; }
        public DateTime? listing { get; set; }
        public DateTime? front { get; set; }
        public DateTime? expiry { get; set; }
        public DateTime? settle { get; set; }
        public DateTime? listedSettle { get; set; }
        public TimeSpan? relistInterval { get; set; }
        public string positionCurrency { get; set; }
        public string underlying { get; set; }
        public string quoteCurrency { get; set; }
        public string underlyingSymbol { get; set; }
        public string reference { get; set; }
        public string referenceSymbol { get; set; }
        public TimeSpan? calcInterval { get; set; }
        public TimeSpan? publishInterval { get; set; }
        public DateTime? publishTime { get; set; }
        public long maxOrderQty { get; set; }
        public decimal? maxPrice { get; set; }
        public int lotSize { get; set; }
        public decimal? tickSize { get; set; }
        public long multiplier { get; set; }
        public string settlCurrency { get; set; }
        public long? underlyingToPositionMultiplier { get; set; }
        public long? underlyingToSettleMultiplier { get; set; }
        public long? quoteToSettleMultiplier { get; set; }
        public bool isQuanto { get; set; }
        public bool isInverse { get; set; }
        public decimal? initMargin { get; set; }
        public decimal? maintMargin { get; set; }
        public long? riskLimit { get; set; }
        public long? riskStep { get; set; }
        public object limit { get; set; }
        public bool taxed { get; set; }
        public bool deleverage { get; set; }
        public decimal? makerFee { get; set; }
        public decimal? takerFee { get; set; }
        public decimal? settlementFee { get; set; }
        public string fundingBaseSymbol { get; set; }
        public string fundingQuoteSymbol { get; set; }
        public string fundingPremiumSymbol { get; set; }
        public DateTime? fundingTimestamp { get; set; }
        public DateTime? fundingInterval { get; set; }
        public decimal? fundingRate { get; set; }
        public decimal? indicativeFundingRate { get; set; }
        public DateTime? rebalanceTimestamp { get; set; }
        public DateTime? rebalanceInterval { get; set; }
        public decimal? prevClosePrice { get; set; }
        public object limitDownPrice { get; set; }
        public object limitUpPrice { get; set; }
        public long totalVolume { get; set; }
        public long volume { get; set; }
        public long volume24h { get; set; }
        public long prevTotalTurnover { get; set; }
        public long totalTurnover { get; set; }
        public long turnover { get; set; }
        public long turnover24h { get; set; }
        public decimal? homeNotional24h { get; set; }
        public decimal? foreignNotional24h { get; set; }
        public decimal? prevPrice24h { get; set; }
        public decimal? vwap { get; set; }
        public decimal? highPrice { get; set; }
        public decimal? lowPrice { get; set; }
        public decimal? lastPrice { get; set; }
        public decimal? lastPriceProtected { get; set; }
        public string lastTickDirection { get; set; }
        public decimal? lastChangePcnt { get; set; }
        public decimal? bidPrice { get; set; }
        public decimal? midPrice { get; set; }
        public decimal? askPrice { get; set; }
        public decimal? impactBidPrice { get; set; }
        public decimal? impactMidPrice { get; set; }
        public decimal? impactAskPrice { get; set; }
        public bool hasLiquidity { get; set; }
        public long openInterest { get; set; }
        public long openValue { get; set; }
        public string fairMethod { get; set; }
        public decimal? fairBasisRate { get; set; }
        public decimal? fairBasis { get; set; }
        public decimal? fairPrice { get; set; }
        public string markMethod { get; set; }
        public decimal? markPrice { get; set; }
        public decimal? indicativeSettlePrice { get; set; }
        public object settledPriceAdjustmentRate { get; set; }
        public object settledPrice { get; set; }
        public DateTime? timestamp { get; set; }
    }
}
