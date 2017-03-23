solve([
    'name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia'
]);

function solve(args) {
    let obj = {};

    for(line of args) {
        let propData = line.split('->').map(x => x.trim());
        obj[propData[0]] = +propData[1] ? +propData[1] : propData[1];
    }

    console.log(JSON.stringify(obj));
}