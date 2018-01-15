function printVolumeArea(radius , height) {
    let volume = Math.PI * (radius * radius) * (height / 3.0);
    console.log(`volume = ${volume}`);

    let area = Math.PI * radius * (radius + Math.sqrt((height * height) + (radius * radius)));
    console.log(`area = ${area}`);
}

printVolumeArea(3, 5);