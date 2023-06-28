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
AppTheme SystemTheme = await Theme.Default.GetSystemThemeAsync();
```
#### ����ϵͳ�������
```
Theme.Default.SystemThemeChanged += ThemeChanged;
```
#### ����ע��
����㲻��ͨ����̬��ʹ�ã�����ͨ������ע��ķ�ʽ
```
builder.Services.AddSingleton<ITheme>(Theme.Default);
```

```
[Inject]
private ITheme Theme { get; set; } = default!;
```

## Language(����)
#### ��ȡ��ǰ���������
```
BrowserLanguage = await Language.Default.GetBrowserLanguageAsync();
```
#### ������������Ըı�
```
Language.Default.BrowserLanguageChanged += LanguageChanged;
```
#### ����ע��
����㲻��ͨ����̬��ʹ�ã�����ͨ������ע��ķ�ʽ
```
builder.Services.AddSingleton<ILanguage>(Language.Default);
```

```
[Inject]
private ILanguage Language { get; set; } = default!;
```

## Browser(�����)
#### ���´���
```
Browser.Default.OpenAsync("https://www.baidu.com");
```
#### ����ע��
����㲻��ͨ����̬��ʹ�ã�����ͨ������ע��ķ�ʽ
```
builder.Services.AddSingleton<IBrowser>(Browser.Default);
```

```
[Inject]
private IBrowser Browser { get; set; } = default!;
```
