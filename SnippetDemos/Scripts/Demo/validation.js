function validateEmail(email) {
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email.toLowerCase());
}

function validatePhoneNo(number, dialingCode) {
    if (dialingCode == null) {
        return /0[0-9]{9,10}$/.test(value);
    }
    else {
        return /^[0-9]+$/.test(value) && value.length <= 15;
    }
}