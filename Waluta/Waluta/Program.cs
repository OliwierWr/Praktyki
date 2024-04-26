using Newtonsoft.Json;
using System.Globalization;
using Waluta.Klasa;

var httpClient= new HttpClient();
var baseAddress = "https://api.nbp.pl/api/exchangerates/rates/";
httpClient.BaseAddress = new Uri (baseAddress);

// reqeust to server
var response = httpClient.GetAsync("C/USD/last/5?format=json").Result;
var contentJson=response.Content.ReadAsStringAsync().Result;
var series = JsonConvert.DeserializeObject<ExchangeRatesSeries>(contentJson);
Console.WriteLine("Podaj ilość PLN");
string PLN_string = Console.ReadLine();
float PLN_float = float.Parse(PLN_string);

foreach (var rate in series.Rates)
{
    float rate_float_bid = float.Parse(rate.Bid, CultureInfo.InvariantCulture);
    float rate_float_ask = float.Parse(rate.Ask, CultureInfo.InvariantCulture);

    float USD_exchanged_bid = PLN_float / rate_float_bid;
    float USD_exchanged_ask = PLN_float / rate_float_ask;
    Console.WriteLine("Data: "+rate.EffectiveDate);
    Console.WriteLine("Bid in USD:"+ USD_exchanged_bid);
    Console.WriteLine("Ask in USD:"+ USD_exchanged_ask);

}