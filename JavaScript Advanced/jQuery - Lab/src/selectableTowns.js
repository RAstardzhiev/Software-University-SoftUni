function attachEvents() {
    $('button#showTownsButton').click(showTowns);

    let unorderedList = $('ul#items');
    unorderedList.find('li').click(itemClicked);

    let resultBox = $('div#selectedTowns');

    function itemClicked() {
        let clickedItem = $(this);
        if (clickedItem.attr('data-selected') !== 'true') {
            clickedItem.attr('data-selected', true);
            clickedItem.css('background', '#DDD');
        } else {
            clickedItem.attr('data-selected', false);
            clickedItem.css('background', '');
        }
    }

    function showTowns() {
        resultBox.text(unorderedList
            .find('[data-selected="true"]')
            .toArray()
            .map(i => i.textContent)
            .join(', '));
    }
}