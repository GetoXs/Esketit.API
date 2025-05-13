using Esketit.API.RequestModels.AccountStatementRequest;
using Esketit.API.RequestModels.AccountSummaryRequest;
using Esketit.API.RequestModels.BuyInvestmentOptionsRequest;
using Esketit.API.RequestModels.BuyInvestmentRequest;
using Esketit.API.RequestModels.InvestOptions;
using Esketit.API.RequestModels.LoginRequest;
using Esketit.API.RequestModels.GetMyInvestmentsRequest;
using Esketit.API.RequestModels.GetPrimaryMarketRequest;
using Esketit.API.RequestModels.GetSecondaryMarketRequest;
using Esketit.API.ResponseModels.AccountStatementResponse;
using Esketit.API.ResponseModels.AccountSummaryResponse;
using Esketit.API.ResponseModels.BuyInvestmentOptionsResponse;
using Esketit.API.ResponseModels.InvestRequest;
using Esketit.API.ResponseModels.LoginResponse;
using Esketit.API.ResponseModels.GetPrimaryMarketQueryResponse;
using Esketit.API.ResponseModels.ProfileResponse;
using Esketit.API.ResponseModels.GetMyInvestmentsResponse;
using Esketit.API.ResponseModels.ReferenceDataResponse;
using Esketit.API.ResponseModels.GetSecondaryMarketResponse;

namespace Esketit.API
{
	public class EsketitClient
	{
		private readonly EsketitProxyApi _proxyApi;
		public string UserAgent => _proxyApi.UserAgent;

		public EsketitClient(string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/134.0.0.0 Safari/537.36")
		{
			_proxyApi = new EsketitProxyApi(userAgent);
		}
		public EsketitClient(EsketitProxyApi proxyApi)
		{
			_proxyApi = proxyApi;
		}

		#region Init
		public async Task InitializeUsingEmailAsync(LoginRequest request)
		{
			var login = await LoginAsync(request);
		}
		#endregion

		#region API endpoints

		#region Without auth

		public async Task<LoginResponse?> LoginAsync(LoginRequest request)
			=> await SendRequest<LoginResponse>(HttpMethod.Post, $"investor/public/login", false, request);

		public async Task<GetPrimaryMarketQueryResponse?> GetPrimaryMarketListAsync(GetPrimaryMarketRequest request)
			=> await SendRequest<GetPrimaryMarketQueryResponse>(HttpMethod.Post, $"investor/public/query-primary-market", false, request);

		public async Task<GetSecondaryMarketQueryResponse?> GetSecondaryMarketListAsync(GetSecondaryMarketRequest request)
			=> await SendRequest<GetSecondaryMarketQueryResponse>(HttpMethod.Post, $"investor/public/query-secondary-market", false, request);

		#endregion

		#region With auth
		public async Task<ProfileResponse?> GetProfileAsync()
			=> await SendRequest<ProfileResponse>(HttpMethod.Get, $"investor/profile", true);

		public async Task<AccountSummaryResponse?> GetAccountSummaryAsync(AccountSummaryRequest request)
			=> await SendRequest<AccountSummaryResponse>(HttpMethod.Post, $"investor/account-summary", true, request);

		public async Task<ReferenceDataResponse?> GetReferenceDataAsync()
			=> await SendRequest<ReferenceDataResponse>(HttpMethod.Post, $"investor/reference-data", true);

		public async Task<AccountStatementResponse?> GetAccountStatementAsync(AccountStatementRequest request)
			=> await SendRequest<AccountStatementResponse>(HttpMethod.Post, $"investor/query-account-statement", true, request);

		public async Task<BuyInvestmentOptionsResponse?> PrimaryMarketInvestOptionsAsync(InvestOptionsRequest request)
			=> await SendRequest<BuyInvestmentOptionsResponse>(HttpMethod.Post, $"investor/invest-options", true, request);

		public async Task PrimaryMarketInvestAsync(InvestRequest request)
			=> await SendRequest<string>(HttpMethod.Post, $"investor/invest", true, request);

		public async Task<BuyInvestmentOptionsResponse?> SecondaryMarketBuyOptionsAsync(BuyInvestmentOptionsRequest request)
			=> await SendRequest<BuyInvestmentOptionsResponse>(HttpMethod.Post, $"investor/buy-investment-options", true, request);

		public async Task SecondaryMarketBuyInvestmentAsync(BuyInvestmentRequest request)
			=> await SendRequest<string>(HttpMethod.Post, $"investor/buy-investment", true, request);

		public async Task<GetMyInvestmentsResponse?> GetMyInvestmentsAsync(GetMyInvestmentsRequest request)
			=> await SendRequest<GetMyInvestmentsResponse>(HttpMethod.Post, $"investor/query-my-investments", true, request);
		#endregion

		public async Task<T?> SendCustomApiAsync<T>(HttpMethod method, string url, bool isAuthorized, object? body = null) => await SendRequest<T>(method, url, isAuthorized, body);

		#endregion

		#region Private functions
		private bool IsAuth() => _proxyApi.IsAuth();
		private void ValidateAuth()
		{
			if (!IsAuth())
				throw new Exception($"Authentication not inicialized.");
		}

		private async Task<T?> SendRequest<T>(HttpMethod method, string url, bool isAuthorized, object? body = null)
		{
			if (isAuthorized)
				ValidateAuth();
			return await _proxyApi.SendRequest<T>(method, url, body);
		}

		#endregion
	}
}
