export function openBrowser(uri, id) {
    let a = document.createElement("a");
    a.setAttribute("href", uri);
    a.setAttribute("target", "_blank");
    a.setAttribute("id", id);     
    if (!document.getElementById(id)) {
        document.body.appendChild(a);
    }
    a.click();
}