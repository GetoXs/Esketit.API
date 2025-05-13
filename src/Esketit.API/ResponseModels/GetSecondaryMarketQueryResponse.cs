namespace Esketit.API.ResponseModels.GetSecondaryMarketResponse
{
	public class GetSecondaryMarketQueryResponse
	{
		public int total { get; set; }
		public Item[] items { get; set; }
	}

	public class Item
	{
		public int investmentId { get; set; }
		public int loanId { get; set; }
		public string issueDate { get; set; }
		public decimal interestRatePercent { get; set; }
		public string currencyCode { get; set; }
		public string currencySymbol { get; set; }
		public int totalPayments { get; set; }
		public int openPayments { get; set; }
		public int closedPayments { get; set; }
		public string maturityDate { get; set; }
		public string nextPaymentDate { get; set; }
		public int termInDays { get; set; }
		public Termperiod termPeriod { get; set; }
		public string originatorCompanyName { get; set; }
		public int originatorId { get; set; }
		public string productCode { get; set; }
		public string productLabel { get; set; }
		public string countryCode { get; set; }
		public string collectionStatus { get; set; }
		public decimal smOfferPrincipalAvailable { get; set; }
		public decimal smDiscountOrPremiumPercent { get; set; }
		public decimal smPrice { get; set; }
	}

	public class Termperiod
	{
		public int years { get; set; }
		public int months { get; set; }
		public int days { get; set; }
	}

}
