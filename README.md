# BlazorToolkit

English || [简体中文](/README.zh-CN.md)

The Blazor toolkit encapsulates some Blazor tool classes, such as obtaining system themes and monitoring changes.

## Start
Install [Yu-Core.BlazorToolkit](https://www.nuget.org/packages/Yu-Core.BlazorToolkit) from NuGet

To use the MauiBlazor toolkit, you need to add it to the root layout file, such as' MainLayout. razor '

```
@Inherits LayoutComponentBase

<BlazorToolkitApp/>
```

## Theme
#### Get the current system theme
```
AppTheme SystemTheme = await Theme.Default.GetSystemThemeAsync();
```
#### Listening system theme change
```
Theme.Default.SystemThemeChanged += ThemeChanged;
```
#### Dependency Registration
If you don't want to use it statically, you can use it through Dependency injection
```
builder.Services.AddSingleton<ITheme>(Theme.Default);
```

```
[Inject]
private ITheme Theme { get; set; } = default!;
```

## Language
#### Get the current browser language
```
BrowserLanguage = await Language.Default.GetBrowserLanguageAsync();
```
#### Listening for browser language changes
```
Language.Default.BrowserLanguageChanged += LanguageChanged;
```

#### Dependency Registration
If you don't want to use it statically, you can use it through Dependency injection
```
builder.Services.AddSingleton<ILanguage>(Language.Default);
```

```
[Inject]
private ILanguage Language { get; set; } = default!;
```

## Browser
#### Open a new window
```
Browser.Default.OpenAsync("https://www.baidu.com");
```
#### Dependency Registration
If you don't want to use it statically, you can use it through Dependency injection
```
builder.Services.AddSingleton<IBrowser>(Browser.Default);
```

```
[Inject]
private IBrowser Browser { get; set; } = default!;
```
