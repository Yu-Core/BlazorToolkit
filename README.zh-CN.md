# BlazorToolkit

[English](/README.md) || 简体中文

Blazor 工具箱，封装了一些 Blazor 的工具类，例如系统主题的获取与监听改变。

## 开始
从 Nuget 安装 [Yu-Core.BlazorToolkit](https://www.nuget.org/packages/Yu-Core.BlazorToolkit)

若要使用 MauiBlazor 工具箱，需要在根布局文件，例如`MainLayout.razor`中添加

```
@inherits LayoutComponentBase

<BlazorToolkitApp/>
```

## Theme(主题)
#### 获取当前系统主题
```
AppTheme SystemTheme = await Theme.Default.GetSystemThemeAsync();
```
#### 监听系统主题更改
```
Theme.Default.SystemThemeChanged += ThemeChanged;
```
#### 依赖注入
如果你不想通过静态来使用，而是通过依赖注入的方式
```
builder.Services.AddSingleton<ITheme>(Theme.Default);
```

```
[Inject]
private ITheme Theme { get; set; } = default!;
```

## Language(语言)
#### 获取当前浏览器语言
```
BrowserLanguage = await Language.Default.GetBrowserLanguageAsync();
```
#### 监听浏览器语言改变
```
Language.Default.BrowserLanguageChanged += LanguageChanged;
```
#### 依赖注入
如果你不想通过静态来使用，而是通过依赖注入的方式
```
builder.Services.AddSingleton<ILanguage>(Language.Default);
```

```
[Inject]
private ILanguage Language { get; set; } = default!;
```

## Browser(浏览器)
#### 打开新窗口
```
Browser.Default.OpenAsync("https://www.baidu.com");
```
#### 依赖注入
如果你不想通过静态来使用，而是通过依赖注入的方式
```
builder.Services.AddSingleton<IBrowser>(Browser.Default);
```

```
[Inject]
private IBrowser Browser { get; set; } = default!;
```
