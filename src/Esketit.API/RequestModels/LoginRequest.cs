namespace Esketit.API.RequestModels.LoginRequest
{
	public class LoginRequest
	{
		public string email { get; set; }
		public string password { get; set; }
		public Webdevicedata webDeviceData { get; set; }
	}

	public class Webdevicedata
	{
		public string original { get; set; }
		public string deviceType { get; set; }
		public string os { get; set; }
		public string osVersion { get; set; }
		public string browser { get; set; }
		public string browserVersion { get; set; }
		public string browserVendor { get; set; }
		public bool isFromIphone { get; set; }
		public bool isFromIpad { get; set; }
		public bool isFromIpod { get; set; }
		public bool isFromIos { get; set; }
		public bool isFromAndroid { get; set; }
		public bool isFromAndroidTablet { get; set; }
		public bool isFromWindowsPhone { get; set; }
		public bool isFromPc { get; set; }
		public bool isFromSmartphone { get; set; }
		public bool isFromMobilephone { get; set; }
		public bool isFromAppliance { get; set; }
		public bool isFromCrawler { get; set; }
		public bool isFromTablet { get; set; }
		public DateTime clientTime { get; set; }
		public string screenResolution { get; set; }
	}

}
