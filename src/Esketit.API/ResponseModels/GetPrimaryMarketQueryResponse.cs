namespace Esketit.API.ResponseModels.GetPrimaryMarketQueryResponse
{

	public class GetPrimaryMarketQueryResponse
	{
		public int total { get; set; }
		public Item[] items { get; set; }
	}

	public class Item
	{
		public int loanId { get; set; }
		public string issueDate { get; set; }
		public decimal interestRatePercent { get; set; }
		public decimal principalIssued { get; set; }
		public decimal principalOffer { get; set; }
		public decimal principalOutstanding { get; set; }
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
		public string originatorNumber { get; set; }
		public int originatorId { get; set; }
		public string productCode { get; set; }
		public string productLabel { get; set; }
		public string countryCode { get; set; }
		public bool hasBuyback { get; set; }
		public int extensions { get; set; }
		public int extendedForDays { get; set; }
		public decimal myInvestments { get; set; }
		public decimal myInvestmentsPercent { get; set; }
		public decimal fundedPercent { get; set; }
		public decimal amountFunded { get; set; }
		public decimal amountAvailable { get; set; }
		public decimal availablePercent { get; set; }
		public object paymentSchedule { get; set; }
		public object loanEvents { get; set; }
		public string loanStatus { get; set; }
	}

	public class Termperiod
	{
		public int years { get; set; }
		public int months { get; set; }
		public int days { get; set; }
	}
}
