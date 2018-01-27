function printValidEmployees(params) {
    let pattern = /^([A-Z][A-Za-z]*) - ([1-9][0-9]*([\.,]{0,1}[0-9]*)) - ([A-Za-z0-9\- ]+)$/;
    let result = '';
    
    for (let i = 0; i < params.length; i++) {
        let match = params[i].match(pattern);
        if (match) {
            result += `Name: ${match[1]}\n` + 
            `Position: ${match[4]}\n` + 
            `Salary: ${match[2]}\n`;
        }
    }

    console.log(result.trim());
}

printValidEmployees(['Jonathan - 2000 - Manager',
    'Peter- 1000- Chuck',
    'George - 1000 - Team Leader ']
);