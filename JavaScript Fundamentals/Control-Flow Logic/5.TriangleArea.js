function getTriangleArea(sideA, sideB, sideC) {
    let semiperimeter = (sideA + sideB + sideC) / 2;
    return Math.sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
}

console.log(getTriangleArea(2, 3.5, 4));