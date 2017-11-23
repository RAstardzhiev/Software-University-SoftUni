function test2(firstWidth, firstHeight, secondWidth, secondHeight) {
    let firstArea = firstWidth * firstHeight;
    let secondArea = secondWidth * secondHeight;
    let excessArea = Math.min(firstWidth, secondWidth) * Math.min(firstHeight, secondHeight);
    return firstArea + secondArea - excessArea;
}