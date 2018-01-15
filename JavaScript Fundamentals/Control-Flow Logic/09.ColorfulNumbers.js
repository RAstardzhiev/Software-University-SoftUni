function printColorfulNumbers(num) {
    var result = '<ul>\n';

    for(let i = 1; i <= num; i++) {
        var color = i % 2 == 0 ? 'blue' : 'green';
        result += `\t<li><span style='color:${color}'>${i}</span></li>\n`;
    }

    result += '</ul>';

    console.log(result);
}

printColorfulNumbers(10);