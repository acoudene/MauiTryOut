using System.Net.Http.Json;

namespace WordGuesserApp.Providers;

public class OpenAIProvider
{
  private readonly HttpClient _httpClient = new HttpClient();

  public async Task<string> GetRandomWordAsync(string theme)
  {
    var requestBody = new { prompt = $"Donne-moi un mot aléatoire sur le thème : {theme}", max_tokens = 10 };
    var response = await _httpClient.PostAsJsonAsync("https://api.openai.com/v1/completions", requestBody);
    var result = await response.Content.ReadAsStringAsync();
    return result; // Traitement à adapter selon la réponse JSON
  }
}

