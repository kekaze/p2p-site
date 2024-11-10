function updateUrl(newUrl) {
    window.history.pushState({}, '', newUrl);
}