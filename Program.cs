using DesafioPokeApi.Models;
using System.Text.Json;

namespace DesafioPokeApi
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static async Task Main()
        {
            string[] pokemons = { "Charmander", "Squirtle", "Caterpie", "Weedle", "Pidgey", "Pidgeotto", "Rattata", "Spearow", "Fearow", "Arbok", "Pikachu", "Sandshrew" };
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            foreach (var name in pokemons)
            {
                try
                {
                    Pokemon? pokemon = null;
                    HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + name.ToLower());
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        pokemon = JsonSerializer.Deserialize<Pokemon>(content, options);
                        Console.WriteLine(pokemon + "\n");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
        }
    }
}