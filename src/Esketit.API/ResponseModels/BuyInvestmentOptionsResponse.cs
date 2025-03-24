namespace Esketit.API.ResponseModels.BuyInvestmentOptionsResponse
{
	public class BuyInvestmentOptionsResponse
	{
		public decimal cashAvailable { get; set; }
		public decimal principalAvailable { get; set; }
		public decimal suggestedAmountToBuy { get; set; }
		public string currencyCode { get; set; }
		public string currencySymbol { get; set; }
	}
}
