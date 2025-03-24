using Esketit.API.Tests.Config;

namespace PeerBerry.API.Tests
{
	public class AuthTests
	{
		private readonly EsketitClient client;

		public AuthTests()
		{
			client = new EsketitClient();
		}

		private async Task Init()
		{
			await client.InitializeUsingEmailAsync(new()
			{
				email = ConfigHelper.GetEnvironmentVariable("EsketitEmail"),
				password = ConfigHelper.GetEnvironmentVariable("EsketitPassword"),
				webDeviceData = new()
				{
					original = client.UserAgent,
					deviceType = "pc",
					os = "Windows 10",
					osVersion = "NT 10.0",
					browser = "Chrome",
					browserVersion = "134.0.0.0",
					browserVendor = "Google",
					isFromIphone = false,
					isFromIpad = false,
					isFromIpod = false,
					isFromIos = false,
					isFromAndroid = false,
					isFromAndroidTablet = false,
					isFromWindowsPhone = false,
					isFromPc = true,
					isFromSmartphone = false,
					isFromMobilephone = false,
					isFromAppliance = false,
					isFromCrawler = false,
					isFromTablet = false,
					clientTime = DateTime.UtcNow,
					screenResolution = "1392x2560"
				}
			});
		}

		[Fact]
		public async Task GetLoans()
		{
			await Init();
			var result = await client.GetMyInvestmentsAsync(new()
			{
				page = 1,
				pageSize = 10,
			});
			Assert.NotNull(result?.items);
		}

		[Fact]
		public async Task GetAccountSummary()
		{
			await Init();
			var result = await client.GetAccountSummaryAsync(new() { currencyCode = "EUR" });
			Assert.True(result?.totalIncome > 0);
		}

		[Fact]
		public async Task GetProfile()
		{
			await Init();
			var result = await client.GetProfileAsync();
			Assert.NotNull(result?.investorNumber);
		}
	}
}