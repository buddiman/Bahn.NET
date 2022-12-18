using Bahn.NET.Timetables.Models;

namespace Bahn.NET.Timetables;

public class TimetablesClient : BahnClient
{
    public TimetablesClient(string clientId, string secret) :
        base(clientId, secret, BahnNetConfig.BASE_URL_TIMETABLES)
    {
    }

    /// <summary>
    /// Returns information about stations matching the given pattern.
    /// There is a limitation in the API itself that only one station will be returned.
    /// </summary>
    /// <param name="searchPattern">can be a station name (prefix), eva number, ds100/rl100 code, wildcard (*); doesn't seem to work with umlauten in station name (prefix)</param>
    /// <returns></returns>
    public async Task<Stations> Station(string searchPattern)
    {
        return await base.Request<Stations>($"station/{searchPattern}");
    }

    public async Task<Timetable> Fchg(string evaNumber)
    {
        return await base.Request<Timetable>($"fchg/{evaNumber}");
    }
    
    public async Task<Timetable> Rchg(string evaNumber)
    {
        return await base.Request<Timetable>($"rchg/{evaNumber}");
    }

    public async Task<Timetable> Plan(string evaNumber, DateTime dateTime)
    {
        return await Plan(evaNumber, dateTime.ToString("yyMMdd"), dateTime.ToString("HH"));
    }

    public async Task<Timetable> Plan(string evaNumber, string date, string hour)
    {
        return await base.Request<Timetable>($"plan/{evaNumber}/{date}/{hour}");
    }
}