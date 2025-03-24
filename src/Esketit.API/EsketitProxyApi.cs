using System.Net;
using System.Net.Http.Json;

namespace Esketit.API
{
	public class EsketitProxyApi : IDisposable
	{
		private readonly HttpClient _httpClient;
		private readonly CookieContainer _cookieContainer = new();
		public string UserAgent { get; }

		public EsketitProxyApi(string userAgent)
		{
			var clientHandler = new HttpClientHandler() { 
				AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.Brotli,
				UseCookies = true,
				CookieContainer = _cookieContainer,
			};
			_httpClient = new HttpClient(clientHandler)
			{
				BaseAddress = new Uri("https://esketit.com/api/"),
			};
			this.UserAgent = userAgent;
		}

		public async Task<T?> SendRequest<T>(HttpMethod method, string url, object? body = null)
		{
			HttpRequestMessage request = new HttpRequestMessage(method, url)
			{
				Content = body != null ? JsonContent.Create(body) : null,
			};
			request.Headers.Add("Accept", "application/json; charset=UTF-8");
			request.Headers.Add("Origin", "https://esketit.com");
			request.Headers.Add("Referer", "https://esketit.com/");
			request.Headers.Add("User-Agent", UserAgent);

			var xsrf = GetXsrf();
			if (xsrf != null)
				request.Headers.Add("X-Xsrf-Token", xsrf);

			var response = await _httpClient.SendAsync(request);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				if (response.StatusCode == HttpStatusCode.Unauthorized)
				{
					throw new UnauthorizedAccessException(await response.Content.ReadAsStringAsync());
				}
				//TODO: log
				throw new Exception(await response.Content.ReadAsStringAsync());
			}
			if (typeof(T) == typeof(string))
				return (T)(object)await response.Content.ReadAsStringAsync();
			return await response.Content.ReadFromJsonAsync<T>();
		}

		private string? GetXsrf()
		{
			return _cookieContainer
				.GetCookies(new Uri("https://esketit.com"))
				?.SingleOrDefault(c => c.Name.ToUpper() == "XSRF-TOKEN")
				?.Value;
		}

		public bool IsAuth() => GetXsrf() != null;

		public void Dispose()
		{
			((IDisposable)_httpClient).Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
