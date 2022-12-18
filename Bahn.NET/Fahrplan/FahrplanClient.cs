using Bahn.NET.Fahrplan.Models;

namespace Bahn.NET.Fahrplan;

public class FahrplanClient : BahnClient
{
    public FahrplanClient(string clientId, string secret) :
        base(clientId, secret, BahnNetConfig.BASE_URL_FAHRPLAN)
    {
    }

    public Task<List<Location>> Location(string searchParam)
    {
        return base.Request<List<Location>>($"location/{searchParam}");
    }
    
    // TODO: Documentation gives different possible date formats. Confusing -> Check this
    // Not enough responses, check if time is needed or which timeframe is covered.
    public async Task<List<Board>> ArrivalBoard(int evaNumber, DateTime dateTime)
    {
        return await ArrivalBoard(evaNumber, dateTime.ToString("yyyy-MM-dd"));
    }
    
    public async Task<List<Board>> ArrivalBoard(int evaNumber, string date)
    {
        return await base.Request<List<Board>>($"arrivalBoard/{evaNumber}?date={date}");
    }
    
    public async Task<List<Board>> DepartureBoard(int evaNumber, DateTime dateTime)
    {
        return await DepartureBoard(evaNumber, dateTime.ToString("yyyy-MM-dd"));
    }
    
    public async Task<List<Board>> DepartureBoard(int evaNumber, string date)
    {
        return await base.Request<List<Board>>($"departureBoard/{evaNumber}?date={date}");
    }
    
    public async Task<List<Journey>> JourneyDetails(string id)
    {
        return await base.Request<List<Journey>>($"journeyDetails/{id}");
    }
}