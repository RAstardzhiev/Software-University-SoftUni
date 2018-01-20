function calculate(firstOperand, secondOperand, operator) {
    let sum = (firstOperand, secondOperand) => firstOperand + secondOperand;
    let subtract = (firstOperand, secondOperand) => firstOperand - secondOperand;
    let multiply = (firstOperand, secondOperand) => firstOperand * secondOperand;
    let divide = (firstOperand, secondOperand) => firstOperand / secondOperand;

    let result = operator === '+' ? sum(firstOperand, secondOperand)
        : operator === '-' ? subtract(firstOperand, secondOperand)
        : operator === '*' ? multiply(firstOperand, secondOperand)
        : operator === '/' ? divide(firstOperand, secondOperand)
        : 'Unrecognised operation';

    return result;
}

console.log(calculate(2, 4, '+'));
console.log(calculate(2, 4, '-'));
console.log(calculate(2, 4, '*'));
console.log(calculate(2, 4, '/'));