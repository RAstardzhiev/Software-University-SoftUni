let printUsernames = arr => console.log(arr.map(e => {
    let atSeparated = e.split('@');
    return atSeparated[0] + '.' + atSeparated[1]
        .split('.')
        .map(a => a[0])
        .join('')
    })
    .join(', '));

// function printUsernames(params) {
//     let usernames = [];
//     params.forEach(e => {
//         let arr = e.split('@');
//         usernames.push(arr[0] + '.' + arr[1].split('.').map(a => a.charAt(0)).join(''));
//     });

//     console.log(usernames.join(', '));
// }


printUsernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);