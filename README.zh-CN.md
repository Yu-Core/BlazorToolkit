# BlazorToolkit

[English](/README.md) || ��������

Blazor �����䣬��װ��һЩ Blazor �Ĺ����࣬����ϵͳ����Ļ�ȡ������ı䡣

## ��ʼ

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
