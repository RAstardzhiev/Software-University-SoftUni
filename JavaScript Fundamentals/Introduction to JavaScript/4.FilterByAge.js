function filterByAge(minimumAge, firstName, firstAge, secondName, secondAge ) {
    if (minimumAge <= firstAge) {
        console.log({ name: firstName, age: firstAge });
    }

    if(minimumAge <= secondAge) {
        console.log({ name: secondName, age: secondAge });
    }
}

FilterByAge(16, 'Hristofor', 99, 'Asen', 16);