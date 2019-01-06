function initUnobtrusiveValidation(form) {
    removeUnobtrusiveValidation(form);
    $.validator.unobtrusive.parse(form);
}

function removeUnobtrusiveValidation(form) {
    var validator = $(form).validate();
    if (validator != null) {
        validator.destroy();
    }
}

// Adds jQuery required validator.
function addRequiredValidator(input, fieldName, errorMessage) {
    var message = errorMessage != null ? errorMessage : 'The ' + fieldName + ' field is required.';
    input.attr('data-val', 'true');
    input.attr('data-val-required', message);
}

// Adds jQuery regex validator.
function addRegexValidator(input, regex, errorMessage) {
    input.attr('data-val', 'true');
    input.attr('data-val-regex-pattern', regex);
    input.attr('data-val-regex', errorMessage);
}