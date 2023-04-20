using Newtonsoft.Json.Linq;

public class Quotes
{
    public Quotes()
    {

    }

    public static void KanyeQuote()
    {
        var client = new HttpClient();

        //Kanye
        var kanyeURL = "https://api.kanye.rest/";
        var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        Console.WriteLine($"{kanyeQuote}\n");
    }

    public static void RonQuote()
    {
        var client = new HttpClient();

        //Ron Swanson
        var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        var ronResponse = client.GetStringAsync(ronURL).Result;
        var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        Console.WriteLine(ronQuote);
    }
}
    
  