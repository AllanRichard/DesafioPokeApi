// Array de pokemons
string[] pokemons = { "Charmander", "Squirtle", "Caterpie", "Weedle", "Pidgey", "Pidgeotto", "Rattata", "Spearow", "Fearow", "Arbok", "Pikachu", "Sandshrew" };

foreach (var pokemon in pokemons)
{
    var name = pokemon.ToLower();
    using var client = new HttpClient();
    var httpResponseMessage = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + name);
    if (httpResponseMessage.IsSuccessStatusCode)
    {
        var content = await httpResponseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(content);
    }
}
