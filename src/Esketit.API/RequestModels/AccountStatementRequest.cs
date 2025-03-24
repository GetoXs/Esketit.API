
namespace Esketit.API.RequestModels.AccountStatementRequest
{
	public class AccountStatementRequest
	{
		public int page { get; set; }
		public int pageSize { get; set; }
		public object sortBy { get; set; }
		public bool sortDesc { get; set; }
		// Object on puropse - to manipulate new params in future.
		public object filter { get; set; }
	}

	public class Filter
	{
		public string currencyCode { get; set; }
		public string dateFrom { get; set; }
		public string dateTo { get; set; }
	}
}
