namespace Esketit.API.ResponseModels.LoginResponse
{
	public class LoginResponse
	{
		public string investorNumber { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string dateOfBirth { get; set; }
		public string email { get; set; }
		public string phoneNumber { get; set; }
		public string country { get; set; }
		public string address { get; set; }
		public bool company { get; set; }
		public string companyName { get; set; }
		public string companyRegistrationNumber { get; set; }
		public string documentNumber { get; set; }
		public string documentExpirationDate { get; set; }
		public string localeCode { get; set; }
		public string investorStatus { get; set; }
		public string investorType { get; set; }
		public string referralPromoCode { get; set; }
		public Accounts accounts { get; set; }
		public Bankaccount[] bankAccounts { get; set; }
		public bool receiveDailySummaryReport { get; set; }
		public bool receiveWeeklySummaryReport { get; set; }
		public bool receiveMonthlySummaryReport { get; set; }
		public bool receiveNotInvestedFundsReminder { get; set; }
		public bool related { get; set; }
		public bool cryptoDepositEnabled { get; set; }
		public bool cryptoEnabled { get; set; }
		public bool twoFactorAuthenticationEnabled { get; set; }
		public string featureFlags { get; set; }
		public bool holdDeposits { get; set; }
		public bool holdInvesting { get; set; }
		public bool holdWithdrawals { get; set; }
	}

	public class Accounts
	{
		public EUR EUR { get; set; }
		public USD USD { get; set; }
	}

	public class EUR
	{
		public string currencyCode { get; set; }
		public string currencySymbol { get; set; }
		public decimal cashBalance { get; set; }
	}

	public class USD
	{
		public string currencyCode { get; set; }
		public string currencySymbol { get; set; }
		public decimal cashBalance { get; set; }
	}

	public class Bankaccount
	{
		public int id { get; set; }
		public string accountNumber { get; set; }
		public string bankName { get; set; }
		public string currencyCode { get; set; }
	}

}
