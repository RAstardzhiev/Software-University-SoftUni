function countOccurances(str, key) {
    let matches = str
        .match(new RegExp(`\\b${key}\\b`, 'gi'));

    return matches === null ? 0 : matches.length
}

console.log(countOccurances('The waterfall was so high, that the child couldn’t see its peak.', 'the'));
console.log(countOccurances('How do you plan on achieving that? How? How can you even think of that?', 'how'));
console.log(countOccurances('There was one. Therefore I bought it. I wouldn’t buy it otherwise.', 'there'));

console.log(countOccurances('The waterfall was so high, that the child couldn’t see its peak.', 'them'));
