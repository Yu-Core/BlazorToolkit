# BlazorToolkit

English || [¼òÌåÖÐÎÄ](/README.zh-CN.md)

The Blazor toolkit encapsulates some Blazor tool classes, such as obtaining system themes and monitoring changes.

## Start

To use the MauiBlazor toolkit, you need to add it to the root layout file, such as' MainLayout. razor '

```
@Inherits LayoutComponentBase

<BlazorToolkitApp/>
```

## Theme
#### Obtain the current system theme
```
AppTheme SystemTheme=await Theme. Default. GetThemeAsync();
```

#### Monitoring system theme change
```
Theme. Default. SystemThemeChanged+=ThemeChanged;
```
