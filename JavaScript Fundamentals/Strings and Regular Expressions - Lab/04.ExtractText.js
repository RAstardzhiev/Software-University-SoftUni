function printParenthesesContent(text) {
    let open = '(';
    close = ')'
    let openIndexes = [];
    let extractedContent = [];

    for (let i = 0; i < text.length; i++) {
        if (text[i] === open) {
            openIndexes.push(i);
        } else if (text[i] === close && openIndexes.length > 0) {
            let startIndex = openIndexes.shift() + 1;
            let parenthesesContent = text.substring(startIndex, i);
            extractedContent.push(parenthesesContent);
        }
    }

    console.log(extractedContent.join(', '));
}

printParenthesesContent('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)');