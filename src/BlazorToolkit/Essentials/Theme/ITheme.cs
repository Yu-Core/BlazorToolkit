namespace BlazorToolkit.Essentials
{
    public interface ITheme
    {
        event Action<AppTheme>? SystemThemeChanged;
        Task<AppTheme> GetThemeAsync();
        Task AddListent();
    }
}
