using RestSharp;

namespace Bahn.NET;

public class BahnClient
{
    private string _clientId;
    private string _secret;
    private readonly RestClient _client;

    protected BahnClient(string clientId, string secret, string baseUrl)
    {
        _clientId = clientId;
        _secret = secret;
        _client = new RestClient(baseUrl)
            .AddDefaultHeader("DB-Api-Key", _secret)
            .AddDefaultHeader("DB-Client-Id", _clientId);
    }

    protected async Task<T> Request<T>(string endpoint)
    {
        var request = new RestRequest(endpoint);
        var response = await _client.ExecuteGetAsync<T>(request);
        return response.Data;
    }
}