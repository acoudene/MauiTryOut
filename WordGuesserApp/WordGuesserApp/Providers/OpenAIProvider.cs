using OpenAI.Chat;

namespace WordGuesserApp.Providers;

public class OpenAiProvider : IAiProvider
{
  public async Task<string> GetRandomWordAsync(string theme)
  {
    string? apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");   
    string prompt = $"Donne-moi un mot aléatoire sur le thème : {theme}";
    string model = "gpt-3.5-turbo";

    ChatClient client = new(model: model, apiKey: apiKey);
    ChatCompletion completion = await client.CompleteChatAsync(prompt);

    return completion.Content.ToString() ?? string.Empty;
  }
}

