function printColorfulNumbers(num) {
    var result = '<ul>\n';

    for(i = 1; i <= num; i++) {
        var color = i % 2 == 0 ? 'blue' : 'green';
        result = result.concat(`\t<li><span style='color:${color}'>${i}</span></li>\n`);
    }

    result = result.concat('</ul>');

    console.log(result);
}

printColorfulNumbers(10);