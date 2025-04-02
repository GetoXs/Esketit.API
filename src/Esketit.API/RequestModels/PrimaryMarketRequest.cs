
namespace Esketit.API.RequestModels.QueryPrimaryMarketRequest
{
	public class PrimaryMarketRequest
	{
		public int page { get; set; }
		public int pageSize { get; set; }
		// Object on puropse - to manipulate new params in future.
		public object filter { get; set; }
	}

	public class Filter
	{
		public string[] products { get; set; }
		public string[] countries { get; set; }
		public string[] originators { get; set; }
		public string principalOfferFrom { get; set; }
		public string currencyCode { get; set; }
		public bool buybackOnly { get; set; }
		public bool excludeAlreadyInvested { get; set; }
		public bool extensions { get; set; }
		public string[] collectionStatuses { get; set; }
		public string remainingTermInDaysFrom { get; set; }
		public string remainingTermInDaysTo { get; set; }
		public string principalOfferTo { get; set; }
		public string interestRatePercentFrom { get; set; }
		public string interestRatePercentTo { get; set; }
	}
}
