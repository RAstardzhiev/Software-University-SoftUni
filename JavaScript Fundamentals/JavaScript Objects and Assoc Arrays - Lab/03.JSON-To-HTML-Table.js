function fromJSONToHTMLTable(params) {
    let sanitizeInput = str => str
        .replace(/&/g, '&amp;')
        .replace(/</g, '&lt;')
        .replace(/>/g, '&gt;')
        .replace(/"/g, '&quot;')
        .replace(/'/g, '&#39;');

    let ident = '   ';
    let table = `<table>\n${ident}<tr>`;
    let parsedObjects = JSON.parse(params);

    // Set Headers
    for (const key in parsedObjects[0]) {
        let thContent = Number.isFinite(key)
            ? key
            : sanitizeInput(key);

        table += `<th>${thContent}</th>`;
    }

    // Set Table Data
    for (let i = 0; i < parsedObjects.length; i++) {
        table += `</tr>\n${ident}<tr>`;

        for (const key in parsedObjects[0]) {
            let tdContent = Number.isFinite(parsedObjects[i][key])
                ? parsedObjects[i][key]
                : sanitizeInput(parsedObjects[i][key]);

            table += `<td>${tdContent}</td>`;
        }
    }

    table += '</tr>\n</table>';
    return table;
}

console.log(fromJSONToHTMLTable(`[{"Name":"Pesho <div>-a","Age":20,"City":"Sofia"},{"Name":"Gosho","Age":18,"City":"Plovdiv"},{"Name":"Angel","Age":18,"City":"Veliko Tarnovo"}]`));
