function composeObj(params) {
    var obj = {};

    if(params.length <= 1) {
        return obj;
    }

    for(i = 0; i < params.length - 1; i++) {
        obj[params[i++]] = params[i];
    }

    return obj;
}

console.log(composeObj(['name', 'Pesho', 'age', '23', 'gender', 'male']));
console.log(composeObj(['ssid', '90127461', 'status', 'admin', 'expires', '600']));