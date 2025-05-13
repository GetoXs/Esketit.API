namespace Esketit.API.RequestModels.GetMyInvestmentsRequest
{
	public class GetMyInvestmentsRequest
	{
		public int page { get; set; }
		public int pageSize { get; set; }
		// Object on puropse - to manipulate new params in future.
		public object filter { get; set; }
	}

	public class Filter
	{
		public bool showActive { get; set; }
		public bool showClosed { get; set; }
		public string currencyCode { get; set; }
		public bool forSale { get; set; }
		public string loanId { get; set; }
		public string[] products { get; set; }
		public string[] countries { get; set; }
		public string[] originators { get; set; }
		public string remainingTermInDaysFrom { get; set; }
		public string remainingTermInDaysTo { get; set; }
		public string interestRatePercentTo { get; set; }
		public string interestRatePercentFrom { get; set; }
		public bool extensions { get; set; }
	}
}
