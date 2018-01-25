let filteredArray = arr => {
    let step = Number(arr.pop());
    return arr
        .filter((e, i) => i % step === 0)
        .join('\n');
} 

console.log(filteredArray(['dsa', 'asd', 'test', 'tset', '2']));
