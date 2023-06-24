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
AppTheme SystemTheme = await Theme.Default.GetThemeAsync();
```

#### 监听系统主题更改
```
Theme.Default.SystemThemeChanged += ThemeChanged;
```
