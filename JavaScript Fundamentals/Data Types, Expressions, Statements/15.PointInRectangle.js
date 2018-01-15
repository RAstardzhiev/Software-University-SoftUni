function isPointInside(params) {
    let pX = params[0];
    let pY = params[1];

    let xMin = params[2];
    let xMax = params[3];
    let yMin = params[4];
    let yMax = params[5];

    return pX <= xMax && pX >= xMin && pY <= yMax && pY >= yMin
        ? 'inside'
        : 'outside';
}

console.log(isPointInside([8, -1, 2, 12, -3, 3]));
console.log(isPointInside([12.5, -1, 2, 12, -3, 3]));