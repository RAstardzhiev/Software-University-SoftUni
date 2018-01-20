function speedCheck(params) {
    let diff = getAllowanceDiff();

    return diff <= 0 ? ''
        : diff <= 20 ? 'speeding'
        : diff <= 40 ? 'excessive speeding'
        : 'reckless driving'
    
    function getAllowanceDiff() {
        let currentSpeed = params[0];
        let area = params[1].toLowerCase();

        let allowances = {
            motorway: 130, 
            interstate: 90, 
            city: 50, 
            residential: 20
        }
        
        return currentSpeed - allowances[area];
    }
}

console.log(speedCheck([40, 'city']));
console.log(speedCheck([21, 'residential']));
console.log(speedCheck([120, 'interstate']));
console.log(speedCheck([200, 'motorway']));