using Newtonsoft.Json; // JSON FRAMEWORK | USED FOR WEB API DEV

// EXPLORE ASYCHRONOUS PROGRAMMING
// USE AN API 
/*
https://api.open-meteo.com/v1/gfs?latitude=40.7251&longitude=-73.2454&current=temperature_2m,rain,wind_speed_10m,wind_direction_10m,wind_gusts_10m&daily=sunrise,sunset&temperature_unit=fahrenheit&wind_speed_unit=mph&precipitation_unit=inch&timezone=America%2FNew_York&forecast_days=1
OPEN-METEO FORECAST API | OPEN-SOURCE - FREE
*/
// CREATE A WINDOW INSTEAD OF PRINTING TO THE CONSOLE
// SHOW THE CURRENT WEATHER IN REAL-TIME
// -TEMPERATURE 
// -WIND
// -MOON PHASE 
// -SUNSET
// -SUNRISE

// CHALLENGE: DETERMINE IDEAL BOATING CONDITIONS

// ====================EXPLORE API SNIPPET
var client = new HttpClient();

var request = new HttpRequestMessage(HttpMethod.Get, "API URL HERE");

var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode(); // Throw an exception if error
 
var body = await response.ReadAsStringAsync();
//==========================================

dynamic data = JsonConvert.DeserializedObject(body);

var temperature = data.current.temperature_2m;
var windSpeed = data.current.wind_speed_10m;
var windGusts = data.current.wind_gusts_10m;
var sunrise = data.daily.sunrise[0];
var sunset = data.daily.sunset[0];

// API DOES NOT INCLUDE MOON PHASE
// LET'S CONSIDER SCRAPING A WEB PAGE TO GET THE MOON PHASE
using System.Net.Http;
// USING STATEMENT FOR ESSENTIAL WEB SCRAPING FUNTIONALITY (LIBRARIES)
using HtmlAgilityPack;
// ===============EXPLORE SCRAPING SNIPPET
// GRAB THE URL OF THE WEB PAGE INTENDED TO SCRAPE DATA FROM
var url = "https://www.moongiant.com/phase/today/";
// INITIALIZE A NEW INSTANCE OF THE HTTP PROTOCOLS TO UTILIZE SCRAPING 
var httpClient = new HttpClient();
// GRAB ONTO THE HMTL REQUEST RESPONSE CONTAINING ALL THE DATA ON THE WEB PAGE
var html = await httpClient.GetStringAsync(url);
// CREATE A NEW PAGE TO ISOLATE DATA 
var htmlDocument = new HtmlDocument();
// LOAD THE THE HTML ONTO THE NEW DOCUMENT OBJECT MODEL
htmlDocument.LoadHtml(html);

// Example: Extracting the title of the page
var titleNode = htmlDocument.DocumentNode.SelectSingleNode("//head/title");
// TODO: FIND THE NODE THAT CONTAINS THE MOON PHASE
// SAVE IN VAR VARIABLE
// PRINT TO CONSOLE THE .INNERTEXT "STRING" OF THE CAPTURED NODE
Console.WriteLine("Page Title: " + titleNode.InnerText)
// =====================================
