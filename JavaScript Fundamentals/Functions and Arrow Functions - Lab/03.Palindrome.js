function isPalindrom(word) {
    for (let i = 0; i < Math.ceil(word.length); i++) {
        if (word[i] !== word[word.length - i - 1]) {
            return false;
        }
    }

    return true;
}

console.log(isPalindrom('haha'));
console.log(isPalindrom('racecar'));
console.log(isPalindrom('unitinu'));