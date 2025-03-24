using Esketit.API.RequestModels.AccountSummaryRequest;
using Esketit.API.RequestModels.BuyInvestmentOptionsRequest;
using Esketit.API.RequestModels.BuyInvestmentRequest;
using Esketit.API.RequestModels.LoginRequest;
using Esketit.API.RequestModels.QueryMyInvestmentsRequest;
using Esketit.API.RequestModels.QueryPrimaryMarketRequest;
using Esketit.API.ResponseModels;
using Esketit.API.ResponseModels.AccountSummaryResponse;
using Esketit.API.ResponseModels.BuyInvestmentOptionsResponse;
using Esketit.API.ResponseModels.LoginResponse;
using Esketit.API.ResponseModels.ProfileResponse;
using Esketit.API.ResponseModels.QueryMarketResponse;
using Esketit.API.ResponseModels.QueryMyInvestmentsResponse;
using Esketit.API.ResponseModels.ReferenceDataResponse;
using Esketit.API.ResponseModels.SecondaryMarketResponse;

namespace Esketit.API
{
	public class EsketitClient
	{
		private readonly EsketitProxyApi _proxyApi;

		public EsketitClient(string agentName = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/134.0.0.0 Safari/537.36")
		{
			_proxyApi = new EsketitProxyApi(agentName);
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

		#endregion

		#region With auth
		public async Task<ProfileResponse?> GetProfileAsync()
			=> await SendRequest<ProfileResponse>(HttpMethod.Post, $"investor/profile", true);

		public async Task<AccountSummaryResponse?> GetAccountSummaryAsync(AccountSummaryRequest request)
			=> await SendRequest<AccountSummaryResponse>(HttpMethod.Post, $"investor/account-summary", true, request);

		public async Task<ReferenceDataResponse?> GetReferenceDataAsync()
			=> await SendRequest<ReferenceDataResponse>(HttpMethod.Post, $"investor/reference-data", true);

		public async Task<QueryMarketResponse?> GetPrimaryMarketListAsync(QueryMarketRequest request)
			=> await SendRequest<QueryMarketResponse>(HttpMethod.Post, $"investor/public/query-primary-market", true, request);

		public async Task<SecondaryMarketResponse?> GetSecondaryMarketListAsync(QueryMarketRequest request)
			=> await SendRequest<SecondaryMarketResponse>(HttpMethod.Post, $"investor/public/query-secondary-market", true, request);

		public async Task<BuyInvestmentOptionsResponse?> BuyInvestmentOptionsAsync(BuyInvestmentOptionsRequest request)
			=> await SendRequest<BuyInvestmentOptionsResponse>(HttpMethod.Post, $"investor/buy-investment-options", true, request);

		public async Task BuyInvestmentOptionsAsync(BuyInvestmentRequest request)
			=> await SendRequest<string>(HttpMethod.Post, $"investor/buy-investment", true, request);

		public async Task<QueryMyInvestmentsResponse?> GetMyInvestmentsAsync(QueryMyInvestmentsRequest request)
			=> await SendRequest<QueryMyInvestmentsResponse>(HttpMethod.Post, $"investor/query-my-investments", true, request);
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
			start:
			try
			{
				return await _proxyApi.SendRequest<T>(method, url, body);
			}
			catch (UnauthorizedAccessException)
			{
				throw;
			}
		}

		#endregion
	}
}
