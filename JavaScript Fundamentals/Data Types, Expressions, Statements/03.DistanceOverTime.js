function getDistanceInMeters(params) {
    let firstObjKmH = params[0];
    let secondObjKmH= params[1];
    let travelTimeInHours = params[2] * 1.0 / 60 / 60;

    let firstObjTravelledDistance = firstObjKmH * travelTimeInHours;
    let secondObjTravelledDistance = secondObjKmH * travelTimeInHours;

    return Math.abs(firstObjTravelledDistance - secondObjTravelledDistance) * 1000;
}

console.log(getDistanceInMeters([0, 60, 3600]));