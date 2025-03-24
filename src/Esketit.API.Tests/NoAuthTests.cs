using Esketit.API.RequestModels.AccountSummaryRequest;
using Esketit.API.RequestModels.LoginRequest;
using Esketit.API.ResponseModels.AccountSummaryResponse;
using Esketit.API.ResponseModels.LoginResponse;
using Esketit.API.Tests.Config;

namespace Esketit.API.Tests
{
	public class NoAuthTests
	{
		[Fact]
		public async Task Test()
		{
			const string agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/134.0.0.0 Safari/537.36";

			var proxy = new EsketitProxyApi(agent);
			var res = await proxy.SendRequest<LoginResponse>(HttpMethod.Post, "investor/public/login", new LoginRequest
			{
				email = ConfigHelper.GetEnvironmentVariable("EsketitEmail"),
				password = ConfigHelper.GetEnvironmentVariable("EsketitPassword"),
				webDeviceData = new()
				{
					original = agent,
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

			var res2 = await proxy.SendRequest<AccountSummaryResponse>(HttpMethod.Post, "investor/account-summary", new AccountSummaryRequest
			{
				currencyCode = "EUR",
			});

		}
	}
}