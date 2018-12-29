function post(url, data, loadingPanel) {
    return ajaxFunc(url, data, 'post', loadingPanel);
}

// Apply JSON.stringify() to data before passing to function.
function postJson(url, data, loadingPanel) {
    return ajaxFunc(url, data, 'post', loadingPanel, 'application/json');
}

function get(url, data, loadingPanel) {
    return ajaxFunc(url, data, 'get', loadingPanel);
}

function ajaxFunc(url, data, type, loadingPanel, contentType) {
    return $.ajax({
        url: url,
        type: type,
        data: data,
        contentType: contentType == null ? 'application/x-www-form-urlencoded; charset=UTF-8' : contentType,
        cache: false
    })
    .then(function (data) {
        // Cause fail if HTTP response code is not 200 (OK).
        return data.responseCode != null ? (data.responseCode != 200 ? $.Deferred().reject(data) : data) : data;
    })
    .fail(function (data) {
        // Handle exception.
        // i.e. Show error message using data.statusText.
    })
    .always(function () {
        if (loadingPanel != null) {
            // Hide loading panel
        }
    })
}