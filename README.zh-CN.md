# BlazorToolkit

[English](/README.md) || ��������

Blazor �����䣬��װ��һЩ Blazor �Ĺ����࣬����ϵͳ����Ļ�ȡ������ı䡣

## ��ʼ
�� Nuget ��װ [Yu-Core.BlazorToolkit](https://www.nuget.org/packages/Yu-Core.BlazorToolkit)

��Ҫʹ�� MauiBlazor �����䣬��Ҫ�ڸ������ļ�������`MainLayout.razor`�����

```
@inherits LayoutComponentBase

<BlazorToolkitApp/>
```

## Theme(����)
#### ��ȡ��ǰϵͳ����
```
AppTheme SystemTheme = await Theme.Default.GetThemeAsync();
```

#### ����ϵͳ�������
```
Theme.Default.SystemThemeChanged += ThemeChanged;
```
