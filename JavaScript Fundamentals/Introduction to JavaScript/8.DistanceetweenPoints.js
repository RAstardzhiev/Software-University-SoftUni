function distanceBetweenPoints(x1, y1, x2, y2) {
    return Math.sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
}

console.log(distanceBetweenPoints(2, 4, 5, 0));