using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMexInterrigator.BitMex.Interfaces
{
    public interface IInstrument
    {
        string symbol { get; set; }
        string rootSymbol { get; set; }
        string state { get; set; }
        string typ { get; set; }
        DateTime? listing { get; set; }
        DateTime? front { get; set; }
        DateTime? expiry { get; set; }
        DateTime? settle { get; set; }
        DateTime? listedSettle { get; set; }
        TimeSpan? relistInterval { get; set; }
        string positionCurrency { get; set; }
        string underlying { get; set; }
        string quoteCurrency { get; set; }
        string underlyingSymbol { get; set; }
        string reference { get; set; }
        string referenceSymbol { get; set; }
        TimeSpan? calcInterval { get; set; }
        TimeSpan? publishInterval { get; set; }
        DateTime? publishTime { get; set; }
        long maxOrderQty { get; set; }
       decimal? maxPrice { get; set; }
        int lotSize { get; set; }
       decimal? tickSize { get; set; }
        long multiplier { get; set; }
        string settlCurrency { get; set; }
        long? underlyingToPositionMultiplier { get; set; }
        long? underlyingToSettleMultiplier { get; set; }
        long? quoteToSettleMultiplier { get; set; }
        bool isQuanto { get; set; }
        bool isInverse { get; set; }
       decimal? initMargin { get; set; }
       decimal? maintMargin { get; set; }
        long? riskLimit { get; set; }
        long? riskStep { get; set; }
        object limit { get; set; }
        bool taxed { get; set; }
        bool deleverage { get; set; }
       decimal? makerFee { get; set; }
       decimal? takerFee { get; set; }
       decimal? settlementFee { get; set; }
        string fundingBaseSymbol { get; set; }
        string fundingQuoteSymbol { get; set; }
        string fundingPremiumSymbol { get; set; }
        DateTime? fundingTimestamp { get; set; }
        DateTime? fundingInterval { get; set; }
        decimal? fundingRate { get; set; }
        decimal? indicativeFundingRate { get; set; }
        DateTime? rebalanceTimestamp { get; set; }
        DateTime? rebalanceInterval { get; set; }
        decimal? prevClosePrice { get; set; }
        object limitDownPrice { get; set; }
        object limitUpPrice { get; set; }
        long totalVolume { get; set; }
        long volume { get; set; }
        long volume24h { get; set; }
        long prevTotalTurnover { get; set; }
        long totalTurnover { get; set; }
        long turnover { get; set; }
        long turnover24h { get; set; }
       decimal? homeNotional24h { get; set; }
       decimal? foreignNotional24h { get; set; }
       decimal? prevPrice24h { get; set; }
        decimal? vwap { get; set; }
       decimal? highPrice { get; set; }
       decimal? lowPrice { get; set; }
       decimal? lastPrice { get; set; }
       decimal? lastPriceProtected { get; set; }
        string lastTickDirection { get; set; }
       decimal? lastChangePcnt { get; set; }
       decimal? bidPrice { get; set; }
       decimal? midPrice { get; set; }
       decimal? askPrice { get; set; }
        decimal? impactBidPrice { get; set; }
        decimal? impactMidPrice { get; set; }
        decimal? impactAskPrice { get; set; }
        bool hasLiquidity { get; set; }
        long openInterest { get; set; }
        long openValue { get; set; }
        string fairMethod { get; set; }
        decimal? fairBasisRate { get; set; }
        decimal? fairBasis { get; set; }
        decimal? fairPrice { get; set; }
        string markMethod { get; set; }
       decimal? markPrice { get; set; }
        decimal? indicativeSettlePrice { get; set; }
        object settledPriceAdjustmentRate { get; set; }
        object settledPrice { get; set; }
        DateTime? timestamp { get; set; }
    }
}
