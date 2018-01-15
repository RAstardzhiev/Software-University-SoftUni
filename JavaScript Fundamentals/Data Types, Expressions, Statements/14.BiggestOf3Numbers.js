function max(params) {
    if(params == null || params.length < 1) {
        return NaN;
    }


    var max = params[0];
    for(let i = 1; i < params.length; i++) {
        if(params[i] > max) {
            max = params[i];
        }
    }

    return max;
}

console.log(max([5, -2, 7]));