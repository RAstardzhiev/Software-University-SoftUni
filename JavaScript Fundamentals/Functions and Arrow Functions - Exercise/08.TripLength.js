function getSegments(params) {
    let x1 = params[0], y1 = params[1];
    let x2 = params[2], y2 = params[3];
    let x3 = params[4], y3 = params[5];

    let getDistance = (x1, y1, x2, y2) => Math.sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

    let firstDistance = getDistance(x1, y1, x2, y2);
    let secondDistance = getDistance(x2, y2, x3, y3);
    let thirdDistance = getDistance(x1, y1, x3, y3);

    let starAtFirstPoint = firstDistance + secondDistance;
    let starAtSecondPoint = secondDistance + thirdDistance;
    let startAtThirdPoint = thirdDistance + firstDistance;

    return starAtFirstPoint <= starAtSecondPoint && starAtFirstPoint <= startAtThirdPoint
        ? `1->2->3: ${starAtFirstPoint}`
        : starAtSecondPoint <= startAtThirdPoint
        ? `1->3->2: ${starAtSecondPoint}`
        : `2->1->3: ${startAtThirdPoint}`;
}

console.log(getSegments([0, 0, 2, 0, 4, 0]));
console.log();
console.log(getSegments([5, 1, 1, 1, 5, 4]));
console.log();
console.log(getSegments([-1, -2, 3.5, 0, 0, 2]));

