namespace Esketit.API.ResponseModels.GetMyInvestmentsResponse
{
	public class GetMyInvestmentsResponse
	{
		public int total { get; set; }
		public Item[] items { get; set; }
		public decimal totalOutstanding { get; set; }
		public decimal totalInterestReceived { get; set; }
		public string currencyCode { get; set; }
		public string currencySymbol { get; set; }
	}

	public class Item
	{
		public int investmentId { get; set; }
		public int loanId { get; set; }
		public decimal interestRatePercent { get; set; }
		public string investmentDate { get; set; }
		public string issueDate { get; set; }
		public string maturityDate { get; set; }
		public string nextPaymentDate { get; set; }
		public int termInDays { get; set; }
		public Termperiod termPeriod { get; set; }
		public int totalPayments { get; set; }
		public int openPayments { get; set; }
		public int closedPayments { get; set; }
		public string originatorCompanyName { get; set; }
		public int originatorId { get; set; }
		public string productCode { get; set; }
		public string productLabel { get; set; }
		public string countryCode { get; set; }
		public string collectionStatus { get; set; }
		public bool closed { get; set; }
		public decimal principalInvested { get; set; }
		public decimal principalOutstanding { get; set; }
		public decimal principalPaid { get; set; }
		public decimal principalPending { get; set; }
		public decimal principalReceived { get; set; }
		public decimal interestPaid { get; set; }
		public decimal interestBonusPaid { get; set; }
		public decimal interestPending { get; set; }
		public decimal interestReceived { get; set; }
		public decimal bonusPaid { get; set; }
		public decimal bonusPending { get; set; }
		public decimal bonusReceived { get; set; }
		public decimal totalPending { get; set; }
		public decimal smOfferPrincipalAvailable { get; set; }
		public decimal smPrincipalSold { get; set; }
		public decimal? smDiscountOrPremiumPercent { get; set; }
		public string currencyCode { get; set; }
		public string currencySymbol { get; set; }
		public string agreementFileName { get; set; }
		public string agreementFileReference { get; set; }
	}

	public class Termperiod
	{
		public int years { get; set; }
		public int months { get; set; }
		public int days { get; set; }
	}

}
