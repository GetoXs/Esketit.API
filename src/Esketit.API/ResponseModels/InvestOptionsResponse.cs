namespace Esketit.API.ResponseModels.InvestOptionsResponse
{
	public class InvestOptionsResponse
	{
		public decimal cashAvailable { get; set; }
		public decimal principalAvailable { get; set; }
		public decimal suggestedAmountToInvest { get; set; }
		public string currencyCode { get; set; }
		public string currencySymbol { get; set; }
	}

}
