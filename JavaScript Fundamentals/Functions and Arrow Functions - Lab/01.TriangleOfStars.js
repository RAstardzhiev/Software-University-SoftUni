function drawTriangle(size) {
    let triangle = '';
    let dillingSymbol = '*';

    for (let i = 1; i <= size; i++) {
        triangle += dillingSymbol.repeat(i) + '\r\n';
    }

    for (let i = size - 1; i > 0; i--) {
        triangle += dillingSymbol.repeat(i) + '\r\n';
    }

    console.log(triangle);
}

drawTriangle(1);
drawTriangle(2);
drawTriangle(5);