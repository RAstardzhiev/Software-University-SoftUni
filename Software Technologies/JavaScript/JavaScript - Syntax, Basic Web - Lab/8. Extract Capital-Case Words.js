solve([
    `We start by HTML, CSS, JavaScript, JSON and REST.`,
    `Later we touch some PHP, MySQL and SQL.`,
    `Later we play with C#, EF, SQL Server and ASP.NET MVC.`,
    `Finally, we touch some Java, Hibernate and Spring.MVC.`
]);

function solve(args) {
    let capitalWords = args
        .join('|')
        .split(/\W+/)
        .map(s => s.trim())
        .filter(s => s.length > 0)
        .filter(s => s === s.toUpperCase())
        .join(", ");

    console.log(capitalWords)
}