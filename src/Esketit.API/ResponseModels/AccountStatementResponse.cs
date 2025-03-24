namespace Esketit.API.ResponseModels.AccountStatementResponse
{
	public class AccountStatementResponse
	{
		public int total { get; set; }
		public Item[] items { get; set; }
		public decimal openingBalance { get; set; }
		public decimal closingBalance { get; set; }
		public decimal primaryMarketPrincipalInvested { get; set; }
		public decimal secondaryMarketPrincipalBought { get; set; }
		public decimal secondaryMarketPrincipalSold { get; set; }
		public decimal secondaryMarketIncome { get; set; }
		public decimal secondaryMarketExpense { get; set; }
		public decimal principalReceived { get; set; }
		public decimal interestReceived { get; set; }
		public decimal bonusReceived { get; set; }
		public decimal referralBonusReceived { get; set; }
		public decimal deposit { get; set; }
		public decimal withdrawal { get; set; }
		public string currencyCode { get; set; }
		public string currencySymbol { get; set; }
	}

	public class Item
	{
		public int txId { get; set; }
		public string txType { get; set; }
		public string txTypeLabel { get; set; }
		public DateTime txTs { get; set; }
		public string txTsFormatted { get; set; }
		public decimal amount { get; set; }
		public decimal cashBalance { get; set; }
		public int? loanId { get; set; }
		public int? investmentId { get; set; }
		public string originatorCompanyName { get; set; }
		public string currencyCode { get; set; }
	}
}
