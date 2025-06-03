namespace Esketit.API.RequestModels.GetSecondaryMarketRequest
{
	public class GetSecondaryMarketRequest
	{
		public int page { get; set; }
		public int pageSize { get; set; }
		// Object on puropse - to manipulate new params in future.
		public object filter { get; set; }
		public string sortBy { get; set; }
		public bool? sortDesc { get; set; }
	}

	public class Filter
	{
		public string[] products { get; set; }
		public string[] countries { get; set; }
		public string[] originators { get; set; }
		public string[] collectionStatuses { get; set; }
		public string? currencyCode { get; set; }
		public decimal? smOfferPrincipalAvailableTo { get; set; }
		public decimal? smOfferPrincipalAvailableFrom { get; set; }
		public int? remainingTermInDaysFrom { get; set; }
		public int? remainingTermInDaysTo { get; set; }
		public decimal? interestRatePercentFrom { get; set; }
		public decimal? interestRatePercentTo { get; set; }
		public bool? extensions { get; set; }
		public decimal? smDiscountOrPremiumPercentFrom { get; set; }
		public decimal? smDiscountOrPremiumPercentTo { get; set; }
		public bool? excludeAlreadyInvested { get; set; }
		public bool? buybackOnly { get; set; }
	}
}
