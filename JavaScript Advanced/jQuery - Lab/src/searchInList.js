function search() {
    let key = $('#searchText').val();
    let foundCounter = 0;

    $('ul#towns li').each((index, item) => {
        if (item.textContent.includes(key)) {
            $(item).css('font-weight', 'bold');
            foundCounter++;
        } else {
            $(item).css('font-weight', '');
        }
    });

    $('#result')
        .text(`${foundCounter} matches found.`);
}

function searchWithoutForEach() {
    let key = $('#searchText')[0].value;
    let items = $('ul#towns li')
        .css('font-weight', '');

    let found = items.filter(`:contains(${key})`);
    found.css('font-weight', 'bold');

    $('#result').text(`${found.length} matches found.`);
}