let printSplittedExpression = expression => console.log(expression
    .split(/[\s().,;]/g)
    .filter(e => e !== '')
    .join('\n')
);

/* Another approach */
// function printSplittedExpression(expression) {
//     let segmentPattern = /[^\s.,();]+/g;
//     let splitPattern = /\\r\\n|\\r|\\n|\\t/g;
//     let result = [];

//     let match;
//     while (match = segmentPattern.exec(expression)) {
//         let element = match[0];
//         if (splitPattern.test(element)) {
//             element.split(splitPattern).forEach(e => result.push(e));
//         }  else {
//             result.push(match);
//         }
//     }

//     console.log(result.join('\n'));
// }

printSplittedExpression('let sum = 4 * 4,b = "wow";');
console.log('*'.repeat(25));
printSplittedExpression('let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}');