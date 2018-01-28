let printSplittedText = (text, delimiter) => console.log(
    text
        .split(delimiter)
        .join('\n')
);

printSplittedText('One-Two-Three-Four-Five', '-');