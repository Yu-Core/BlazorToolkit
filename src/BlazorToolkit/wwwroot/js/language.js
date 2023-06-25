export function followBrowserLanguage(dotNet, callbackMethod) {
    window.addEventListener("languagechange", () => {
        dotNet.invokeMethodAsync(callbackMethod, getBrowserLanguage());
    });
}
export function getBrowserLanguage() {
    var language = navigator.language || navigator.browserLanguage;
    if (language.indexOf('-') !== -1) {
        language = language.split('-')[0] + '-' + language.split('-')[1].toUpperCase();
    }
    return language;
}