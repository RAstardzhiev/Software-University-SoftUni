function printChessBoard(num) {
    let board = '<div class="chessboard">\n';

    for(let i = 0; i < num; i++) {
        board += '\t<div>\n';

        for(let j = 0; j < num; j++) {
            var color = (i + j) % 2 == 0 ? 'black' : 'white';
            board += `\t\t<span class="${color}"></span>\n`;
        }

        board += '\t</div>\n';
    }

    board += '</div>';

    console.log(board);
}

printChessBoard(3);