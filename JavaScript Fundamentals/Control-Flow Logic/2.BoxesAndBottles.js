function bottlesInBoxes(bottles, boxCapacity) {
    let neededBoxes = bottles / boxCapacity;
    return neededBoxes * boxCapacity >= bottles
        ? Math.ceil(neededBoxes)
        : Math.ceil(neededBoxes) + 1;
}

console.log(bottlesInBoxes(15, 7));
console.log(bottlesInBoxes(15, 10));