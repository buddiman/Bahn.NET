using System.Reflection;
using Bahn.NET.Fahrplan;
using Bahn.NET.Timetables;
using Microsoft.Extensions.Configuration;

const string city = "Fulda";

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json")
    .AddUserSecrets(Assembly.GetExecutingAssembly(), true).Build().GetSection("ClientSettings");
var clientId = configuration["ClientID"];
var clientSecret = configuration["ClientSecret"];

var date = new DateTime(2022, 12, 18, 12, 0, 0);

var timetablesClient = new TimetablesClient(clientId, clientSecret);
var fahrplanClient = new FahrplanClient(clientId, clientSecret);

var fahrplanLocations = await fahrplanClient.Location(city);
var location = fahrplanLocations.First(f => f.Name.Contains(city));
var arrivalBoards = await fahrplanClient.ArrivalBoard(location.Id, date);
var journey = await fahrplanClient.JourneyDetails(arrivalBoards.First().DetailsId);

var timetablesLocation = await timetablesClient.Station(city);
var fchg = await timetablesClient.Fchg(timetablesLocation.Station.Eva);
var rchg = await timetablesClient.Rchg(timetablesLocation.Station.Eva);
var plan = await timetablesClient.Plan(timetablesLocation.Station.Eva, date);

Console.WriteLine("");