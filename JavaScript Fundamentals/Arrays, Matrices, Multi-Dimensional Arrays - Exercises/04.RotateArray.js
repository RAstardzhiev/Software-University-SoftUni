function printRotatedArray(params) {
    let elementsToRotate = Number(params.pop()) % params.length;
    for (let i = 0; i < elementsToRotate; i++) {
        params.unshift(params.pop());
    }

    console.log(params.join(' '));    
}

printRotatedArray(['1', '2', '3', '4', '2']);