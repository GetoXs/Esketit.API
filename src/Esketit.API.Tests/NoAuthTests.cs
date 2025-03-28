using Esketit.API.Tests.Config;

namespace Esketit.API.Tests
{
	public class NoAuthTests
	{
		private readonly EsketitClient client;
		public NoAuthTests()
		{
			client = new EsketitClient();
		}

		[Fact]
		[Trait("CI", "true")]
		public async Task GetPrimaryMarketList()
		{
			var list = await client.GetPrimaryMarketListAsync(new()
			{
				page = 1,
				pageSize = 10,
			});

			Assert.NotNull(list);
		}

		[Fact]
		[Trait("CI", "true")]
		public async Task GetSecondaryMarketList()
		{
			var list = await client.GetSecondaryMarketListAsync(new()
			{
				page = 1,
				pageSize = 10,
			});

			Assert.NotNull(list);
			Assert.True(list.items.Length > 0);
		}

		[Fact]
		public async Task Login()
		{
			await client.LoginAsync(new()
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
	}
}