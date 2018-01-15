function getFeet(totalInches) {
    var inchesPerFeet = 12;
    let feet = Math.floor(totalInches / inchesPerFeet);
    let inches = totalInches % inchesPerFeet;

    return `${feet}'-${inches}"`;
}

console.log(getFeet(36));
console.log(getFeet(55));
console.log(getFeet(11));