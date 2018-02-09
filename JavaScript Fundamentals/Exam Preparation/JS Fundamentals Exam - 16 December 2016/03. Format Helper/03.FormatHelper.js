function formatText([text]) {
    return text
        .replace(/([.,!?:;])(?=[^\s.]+)/gm, m => m + ' ') // After punctuation -> Lack of space
        .replace(/([.,!?:;])\s{2,}/gm, (match, g1) => g1 + ' ') // After punctuation -> Multiple spaces
        .replace(/\s+([.,!?:;])/gm, (match, g1) => g1) // Before punctuation
        .replace(/([0-9]+)(\s*\.\s*?)(?=[0-9])/gm, (match, g1) => g1 + '.') // Digits with Dot
        .replace(/(")(\s*.+?\s*)\1/gm, (match, g1, g2) => g1 + g2.trim() + g1); // Quotes
}

console.log(formatText(
    [`Now let's test           , absolutely everything!Aposiopesis is this: ...Have! you read the constraints?, you squidward? It would be pretty sad if this also fails "         !It would be bad if you don't put space after the explanation at start,aposiopesis all the way...". Now; 8   . 1 3. 0x041       .   I hope this will be trimmed too     !`]
    // [`Test everything, including:dates    : 4.     3         .10, digits:1,2,3,4,numbers :  14.4,15.6,3. Quotation should be should be trimmed after additional spaces are given:"Quote should remain the same, even with explanation mark in the end!"; this quote should be trimmed in the beginning: "   Trim start"!`]
    // [`We should test how digits and dates would be printed: first some digit - 9,than some number  : 3      . 14    ! Do not forget about the dates though: 09  .   11; Now, spam more: 311 .1, 31 . not number 31   .   31 .  2031!`]
    // [`Now, let's test some! $#@!1! strange symbols followed, be some more: (@!#$#@$DF%$);NewLines cannot be used, tear! ):`]
    // ['Terribly formatted text  . . . !  With chaotic spacings." Terrible quoting "! Also this date is pretty confusing : 20 . 12. 16 .']
));