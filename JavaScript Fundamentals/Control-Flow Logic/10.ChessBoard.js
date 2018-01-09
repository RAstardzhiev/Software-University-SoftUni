function printChessBoard(num) {
    let board = '<div class="chessboard">\n';

    for(i = 0; i < num; i++) {
        board = board.concat('\t<div>\n');

        for(j = 0; j < num; j++) {
            var color = (i + j) % 2 == 0 ? 'black' : 'white';

            board = board.concat(`\t\t<span class="${color}"></span>\n`);
        }

        board = board.concat('\t</div>\n');
    }

    board = board.concat('</div>');

    console.log(board);
}

printChessBoard(3);