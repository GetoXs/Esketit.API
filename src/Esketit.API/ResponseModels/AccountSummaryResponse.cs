namespace Esketit.API.ResponseModels.AccountSummaryResponse
{
	public class AccountSummaryResponse
	{
		public string currency { get; set; }
		public string currencySymbol { get; set; }
		public decimal cashBalance { get; set; }
		public decimal principalInvested { get; set; }
		public decimal principalPending { get; set; }
		public decimal interestPending { get; set; }
		public decimal originatorPaymentsPending { get; set; }
		public decimal bonusPending { get; set; }
		public decimal referralBonusPending { get; set; }
		public decimal totalPending { get; set; }
		public decimal principalReceived { get; set; }
		public decimal interestReceived { get; set; }
		public decimal bonusReceived { get; set; }
		public decimal referralBonusReceived { get; set; }
		public decimal principalPaid { get; set; }
		public decimal accountValue { get; set; }
		public object[] pendingWithdrawals { get; set; }
		public object[] unconfirmedWithdrawals { get; set; }
		public decimal interestPaid { get; set; }
		public int interestBonusPaid { get; set; }
		public decimal bonusPaid { get; set; }
		public decimal referralBonusPaid { get; set; }
		public decimal secondaryMarketIncome { get; set; }
		public decimal secondaryMarketExpense { get; set; }
		public decimal secondaryMarketTotal { get; set; }
		public decimal totalIncome { get; set; }
		public int internalRateOfReturnPercent { get; set; }
		public bool internalRateOfReturnPercentCalculated { get; set; }
		public decimal principalCurrent { get; set; }
		public decimal principalLate15 { get; set; }
		public decimal principalLate30 { get; set; }
		public decimal principalLate60 { get; set; }
		public int principalLate61plus { get; set; }
		public int totalInvestments { get; set; }
	}

}
