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
AppTheme SystemTheme = await Theme.Default.GetThemeAsync();
```
#### Listening system theme change
```
Theme.Default.SystemThemeChanged += ThemeChanged;
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

## Browser
#### Open a new window
```
Browser.Default.OpenAsync("https://www.baidu.com");
```