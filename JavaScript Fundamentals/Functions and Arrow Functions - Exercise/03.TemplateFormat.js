function formatAsXml(params) {
    let tab = '  ';
    let newLine = '\r\n';

    let result = `<?xml version="1.0" encoding="UTF-8"?>${newLine}<quiz>${newLine}`;

    for (let i = 0; i < params.length; i++) {
        result += `${tab}<question>${newLine}`;
        result += `${tab.repeat(2)}${params[i++]}${newLine}`;
        result += `${tab}</question>${newLine}`;
        result += `${tab}<answer>${newLine}`;
        result += `${tab.repeat(2)}${params[i]}${newLine}`;
        result += `${tab}</answer>${newLine}`;
    }

    result += '</quiz>';
    return result;
}

let xml =  formatAsXml(['Dry ice is a frozen form of which gas?', 'Carbon Dioxide',
    'What is the brightest star in the night sky?', 'Sirius']);

console.log(xml);