namespace BlazorToolkit.Essentials
{
    public interface ILanguage
    {
        event Action<string>? BrowserLanguageChanged;
        Task<string> GetBrowserLanguageAsync();
        Task AddListent();
    }
}
