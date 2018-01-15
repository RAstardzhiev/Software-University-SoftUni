function getDistance(numbers) {
    let x1 = numbers[0];
    let y1 = numbers[1];
    let z1 = numbers[2];
    let x2 = numbers[3];
    let y2 = numbers[4];
    let z2 = numbers[5];

    let distance = Math.sqrt(
        ((x2 - x1) * (x2 - x1)) +
        ((y2 - y1) * (y2 - y1)) +
        ((z2 - z1) * (z2 - z1))
    );

    return distance;
}

console.log(
    getDistance([1, 1, 0, 5, 4, 0])
);

console.log(
    getDistance([3.5, 0, 1, 0, 2, -1])
);