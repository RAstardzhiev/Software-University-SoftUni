function  oddOrEven(num) {
    if(num != Math.floor(num)) {
        return 'invalid';
    }
    else if(num % 2 == 0) {
        return 'even';
    }
    else {
        return 'odd';
    }
}