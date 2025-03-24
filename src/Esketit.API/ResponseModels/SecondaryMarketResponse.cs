namespace Esketit.API.ResponseModels.SecondaryMarketResponse
{
	public class SecondaryMarketResponse : QueryMarketResponse.QueryMarketResponse
	{
		public decimal smOfferPrincipalAvailable { get; set; }
		public decimal smDiscountOrPremiumPercent { get; set; }
		public decimal smPrice { get; set; }
	}
}
