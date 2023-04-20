

using Newtonsoft.Json.Linq;

bool cont = true;

do
{
    Quotes.KanyeQuote();
    Quotes.RonQuote();

    Console.WriteLine("Continue? Y or N7?");
    var response = Console.ReadLine().ToLower();

    cont = (response == "n") ? false : true;

} while (cont);
    
