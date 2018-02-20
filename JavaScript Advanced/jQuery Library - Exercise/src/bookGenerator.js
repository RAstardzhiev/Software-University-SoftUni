// IIFE (Immediately Invoked Function Expression)
/*
No Fragment (Directly appending) - Time Measured:
    1: 6.999999983236194 milliseconds.
    2: 2.0000000949949026 milliseconds.
    3: 0.9999999310821295 milliseconds.
*/
let createBook = (function () {
    let id = 1;
    return function (selector, title, author, isbn) {
        // let start = performance.now();

        $(selector).append(
            $(`<div id="book${id++}">`).append(
                $(`<p class="title">${title}</p>`),
                $(`<p class="author">${author}</p>`),
                $(`<p class="isbn">${isbn}</p>`),
                $('<button>').text('Select').on('click', function () {
                    $(this).parent().css('border', '2px solid blue');
                }),
                $('<button>').text('Deselect').on('click', function () {
                    $(this).parent().css('border', 'none');
                })
            ));

        // let end = performance.now();
        // console.dir((id - 1) + ': ' + (end - start) + ' milliseconds.');
    }
}())

/*
With Fragment - Time Measured:
    1: 10.999999940395355 milliseconds.
    2: 3.9999999571591616 milliseconds.
    3: 3.9999999571591616 milliseconds.
*/
let createBookWithFragment = (function () {
    let id = 1;
    return function (selector, title, author, isbn) {
        // let start = performance.now();

        let container = $(selector);
        let fragment = document.createDocumentFragment();
        $(fragment).append(
            $(`<div id="book${id++}">`).append(
                $(`<p class="title">${title}</p>`),
                $(`<p class="author">${author}</p>`),
                $(`<p class="isbn">${isbn}</p>`),
                $('<button>').text('Select').on('click', function () {
                    $(this).parent().css('border', '2px solid blue');
                }),
                $('<button>').text('Deselect').on('click', function () {
                    $(this).parent().css('border', 'none');
                })
            ));

        container.append(fragment);

        // let end = performance.now();            
        // console.dir('With Fragment');
        // console.dir((id - 1) + ': ' + (end - start) + ' milliseconds.');
    }
}())

/* Without IIFE */
/*
Without IIFE - Time Measured:
    1: 13.999999966472387 milliseconds.
    2: 0.9999999310821295 milliseconds.
    3: 3.000000026077032 milliseconds.
*/
function createBookWithout_IIFE(selector, title, author, isbn) {
    // let start = performance.now();

    let container = $(selector);

    let existingBooks = container
        .find('[id^="book"]'); // ^= (starts with)

    container.append(
        $(`<div id="book${existingBooks.length + 1}">`).append(
            $(`<p class="title">${title}</p>`),
            $(`<p class="author">${author}</p>`),
            $(`<p class="isbn">${isbn}</p>`),
            $('<button>').text('Select').click(select),
            $('<button>').text('Deselect').click(deselect)
        ));

    // let end = performance.now();
    // console.dir((existingBooks.length + 1) + ': ' + (end - start) + ' milliseconds.');

    function select() {
        $(this).parent().css('border', '2px solid blue');
    }

    function deselect() {
        $(this).parent().css('border', 'none');
    }
}