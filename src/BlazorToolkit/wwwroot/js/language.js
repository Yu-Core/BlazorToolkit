export function followBrowserLanguage(dotNet, callbackMethod) {
    window.addEventListener("languagechange", () => {
        dotNet.invokeMethodAsync(callbackMethod, getBrowserLanguage());
    });
}
export function getBrowserLanguage() {
    return (navigator.language || navigator.browserLanguage).toLowerCase();
}