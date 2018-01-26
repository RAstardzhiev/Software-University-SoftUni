function generateHtmlList(params) {
    let result = '<ul>\n';

    for (let i = 0; i < params.length; i++) {
        let sanitizedLine = sanitizeHtml(params[i]);
        result += `\t<li>${sanitizedLine}</li>\n`;
    }

    result += '</ul>'
    return result;

    function sanitizeHtml(html) {
        let symbols = [
            { danger: '&', safe: '&amp;' },
            { danger: '<', safe: '&lt;' },
            { danger: '>', safe: '&gt;' },
            { danger: '"', safe: '&quot;' }
        ];

        for (let i = 0; i < symbols.length; i++) {
            let indexOfDanger = html.indexOf(symbols[i].danger);
            while (indexOfDanger >= 0) {
                html = html.replace(symbols[i].danger, symbols[i].safe);
                indexOfDanger = html.indexOf(symbols[i].danger, indexOfDanger + 1);
            }
        }

        return html;
    }
}

console.log(generateHtmlList(['<b>unescaped text</b>', 'normal text']));
