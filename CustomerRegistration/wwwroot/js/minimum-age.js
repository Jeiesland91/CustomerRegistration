jQuery.validator.addMethod("minimumage", function (value, element, param) {
    if (value === '') return false;

    var minYears = Number(param);

    if (int(value) < minYears) {
        return false;
    }

    return true;

});

jQuery.validator.unobtrusive.adapters.addSingleVal("minimumage", "years");