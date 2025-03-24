namespace Esketit.API.ResponseModels.ReferenceDataResponse
{
	public class ReferenceDataResponse
	{
		public Country[] countries { get; set; }
		public Product[] products { get; set; }
		public Originator[] originators { get; set; }
		public Collectionstatus[] collectionStatuses { get; set; }
	}

	public class Country
	{
		public string id { get; set; }
		public string label { get; set; }
	}

	public class Product
	{
		public string id { get; set; }
		public string label { get; set; }
	}

	public class Originator
	{
		public string id { get; set; }
		public string label { get; set; }
	}

	public class Collectionstatus
	{
		public string id { get; set; }
		public string label { get; set; }
	}

}
