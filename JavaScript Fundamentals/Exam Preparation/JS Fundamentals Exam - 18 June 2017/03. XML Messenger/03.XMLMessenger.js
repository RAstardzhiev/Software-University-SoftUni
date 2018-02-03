function xmlToHtml(xml) {
    let validationMatch = /^<message(\s*[a-z]+="[A-Za-z0-9 \.]+"\s*)+>([\s\S]+)<\/message>$/gm.exec(xml);

    let invalidMessageFormat = 'Invalid message format';
    if (!validationMatch) {
        return invalidMessageFormat;
    }

    let fromMatch = /\bfrom="([A-Za-z0-9 \.]+)"/gm.exec(xml);
    let toMatch = /\bto="([A-Za-z0-9 \.]+)"/gm.exec(xml);
    if (!fromMatch || !toMatch) {
        return 'Missing attributes';
    }

    let messageLines = validationMatch[2].split('\n');
    let ident = '  ';
    let html = '<article>\n' +
        ident + `<div>From: <span class="sender">${fromMatch[1]}</span></div>\n` +
        ident + `<div>To: <span class="recipient">${toMatch[1]}</span></div>\n` +
        ident + '<div>\n';

    for (const line of messageLines) {
        html += ident + ident + `<p>${line}</p>\n`;
    }

    html += ident + '</div>\n' +
        '</article>';

    return html;
}

// console.log(xmlToHtml(`<message to="Bob" from="Alice" timestamp="1497254092">Hey man, what's up?</message>`));

// console.log();

// Test 6
console.log(xmlToHtml(`<message mailto="everyone" from="Grandma" to="Everyone">FWD: FWD: FWD: FWD: Forwards from grandma</message>`));
