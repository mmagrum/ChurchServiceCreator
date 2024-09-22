using ChurchServiceCreator.Functions;
using ChurchServiceCreator.Models;
using System.Text.Json;

var cfgFile = File.ReadAllText("appConfig.json");
var Config = JsonSerializer.Deserialize<appConfig>(cfgFile);
var PlanSunday = DateTime.Today.AddDays(14 - (int)DateTime.Today.DayOfWeek).ToShortDateString();
//if (args.Length > 0)
Console.WriteLine($"This application will give you song suggestions based on a given topic. What topic would you like suggestions for?");
string? Topic = Console.ReadLine();
Console.WriteLine($"Also show performance pieces (instrumental/choir/solo)? (Yes - default is no)");
string? Performance = Console.ReadLine();
if (Topic != null && Config != null)
{
    var lastPerformed = DateTime.Today.AddMonths(Config.lastSungMonths * -1);
    Console.WriteLine($"Searching for songs matching {Topic} last sung before {lastPerformed.ToShortDateString()}...");

    //Check for song titles that match the theme
    string Query = $"songs?where[title]={Topic}&per_page=50";
    var api = new apiCall();
    var response = api.Get(Config.url, Config.appId, Config.secret, Query);
    var songList = JsonSerializer.Deserialize<Song.Root>(response);
    
    //Check the song theme itself for the theme value (except psalms)
    Query = $"songs?per_page=50&where[themes]={Topic}";
    response = api.Get(Config.url, Config.appId, Config.secret, Query);
    var songlist2 = JsonSerializer.Deserialize<Song.Root>(response);
    songList.data.AddRange(songlist2.data);
    
    if (songList.data.Count > 0)
    {
        List<SongMatch> songOutput = new List<SongMatch>();
        foreach (var song in songList.data)
        {
            if (song.attributes.last_scheduled_at < lastPerformed || song.attributes.last_scheduled_at == null)
            {
                SongMatch songMatch = new SongMatch();
                songMatch.lastScheduled = song.attributes.last_scheduled_short_dates;
                songMatch.songTitle = song.attributes.title;
                songMatch.author = song.attributes.author;
                songMatch.themes = song.attributes.themes;
                string checkperf = (song.attributes.themes ?? "").ToLower();
                if (!(checkperf.Contains("instrumental") || checkperf.Contains("solo") || checkperf.Contains("choir")))
                    songOutput.Add(songMatch);
                else if ((Performance ?? "").ToLower() == "yes")
                    songOutput.Add(songMatch);
            }
        }
        Random rnd = new Random();
        foreach (var song in songOutput.Distinct().Select(x => new { value = x, order = rnd.Next() }).OrderBy(x => x.order).Select(x => x.value).Take(Config.resultsReturned))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(song.songTitle);
            Console.ResetColor();
            Console.WriteLine($"  by {song.author}");
            Console.WriteLine($"  last sung {song.lastScheduled ?? "Never"}");
            Console.WriteLine($"  themes: {song.themes}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();
        }
        Console.ReadKey();
        System.Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("No match found for that topic. Please run the program again with a new search phrase.");
        Console.ReadKey();
        System.Environment.Exit(0);
    }
}
else if(Config == null || Config.appId == null || Config.secret == null)
{
    Console.WriteLine("You did not fill out your configuration file with the proper values for appId and secret. Please update that and try again");
    Console.ReadKey();
    System.Environment.Exit(0);
}
else
{
    Console.WriteLine("You gotta give me a topic to work with! Run me again when you have a topic in mind.");
    Console.ReadKey();
    System.Environment.Exit(0);
}