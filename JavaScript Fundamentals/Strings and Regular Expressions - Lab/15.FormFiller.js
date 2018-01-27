/* Arrow solution -> 0.513 seconds */
let printReplacedPlaceholders = (username, email, phoneNumber, params) => console.log(
    params.join('\n')
    .replace(/<![A-Za-z]+!>/g, username)
    .replace(/<@[A-Za-z]+@>/g, email)
    .replace(/<\+[A-Za-z]+\+>/g, phoneNumber)
);


/* Function solution -> 0.644 seconds */
// function printReplacedPlaceholders(username, email, phoneNumber, params) {
//     let placeHolers = {
//         username: /<![A-Za-z]+!>/g,
//         email: /<@[A-Za-z]+@>/g,
//         phoneNumber: /<\+[A-Za-z]+\+>/g
//     }

//     let result = params.join('\n')
//         .replace(placeHolers.username, username)
//         .replace(placeHolers.email, email)
//         .replace(placeHolers.phoneNumber, phoneNumber);

//     console.log(result);
// }

printReplacedPlaceholders('Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    ['Hello, <!username!>!',
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']
);