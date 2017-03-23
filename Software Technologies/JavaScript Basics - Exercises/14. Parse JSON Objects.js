solve([
    '{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}'

]);

function solve(args) {
    let people = [];
    for(line of args) {
        people.push(JSON.parse(line));
    }

    for(human of people) {
        console.log(`Name: ${human.name}`);
        console.log(`Age: ${human.age}`);
        console.log(`Date: ${human.date}`);
    }
}