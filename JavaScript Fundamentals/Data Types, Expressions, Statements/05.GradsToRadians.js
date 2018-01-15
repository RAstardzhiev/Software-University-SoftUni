function getDegrees(grads) {
    let degrees = (grads * 0.90) % 360;

    return degrees >= 0
        ? degrees
        : 360 + degrees;
}

console.log(getDegrees(100));
console.log(getDegrees(400));
console.log(getDegrees(850));
console.log(getDegrees(-50));