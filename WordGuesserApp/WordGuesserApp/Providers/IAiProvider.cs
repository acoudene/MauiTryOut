namespace WordGuesserApp.Providers;

public interface IAiProvider
{
  Task<string> GetRandomWordAsync(string theme);
}