function toHtml(json) {
    let parsedJson = JSON.parse(json);
    let ident = '  ';
    let sanitizeInput = str => str
        .replace(/&/g, '&amp;')
        .replace(/</g, '&lt;')
        .replace(/>/g, '&gt;')
        .replace(/"/g, '&quot;')
        .replace(/'/g, '&#39;');

    let html = '<table>\n' + `${ident}<tr><th>name</th><th>score</th></tr>\n`;

    for (let i = 0; i < parsedJson.length; i++) {
        let name = sanitizeInput(parsedJson[i].name);
        html += `${ident}<tr><td>${name}</td><td>${Number(parsedJson[i].score)}</td></tr>\n`;
    }

    html += '</table>';
    return html;
}

console.log(toHtml('[{"name":"Pesho & &","score":479},{"name":"Gosho","score":"<script>Some JS</script>"}]'));
