solve([
    'Pesho -> 13 -> 6.00',
    'Ivan -> 12 -> 5.57',
    'Toni -> 13 -> 4.90'
]);

function solve(args) {
    let students = [];
    for(line of args) {
        let student = line.split('->').map(x => x.trim());
        students.push({
            name: student[0],
            age: Number(student[1]),
            grade: Number(student[2])
        });
    }

    for(student of students) {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade.toFixed(2)}`);
    }
}