function domSearch(selector, isCaseSensitive) {
    // Result
    let listItems = $('<ul>')
        .addClass('items-list');

    let resultClontainer = $('<div>')
        .addClass('result-controls')
        .append(listItems)

    // Add
    let addInputBox = $('<input>');
    let addContainer = $('<div>')
        .addClass('add-controls')
        .append($('<label>')
            .text('Enter text:')
            .append(addInputBox))
        .append($('<a>')
            .addClass('button')
            .css('displa', 'inline-block')
            .text('Add')
            .on('click', function () {
                // Input validation
                let text = addInputBox.val().trim();
                if (text === '' || text.length === 0) {
                    return;
                }

                // Item creation
                listItems.append($('<li>')
                    .addClass('list-item')
                    .append($('<a>') // Delete Button
                        .addClass('button')
                        .text('X')
                        .on('click', function () {
                            $(this).parent().remove()
                        }))
                    .append($('<strong>') // Item Text
                        .text(text)));
            }));

    // Search
    let searchInputBox = $('<input>');
    let searchContainer = $('<div>')
        .addClass('search-controls')
        .append($('<label>')
            .text('Search:')
            .append(searchInputBox)
            .on('change keyup paste cut', processSearch));

    $(selector)
        .append(addContainer)
        .append(searchContainer)
        .append(resultClontainer);

    function processSearch() {
        let key = isCaseSensitive
            ? searchInputBox.val()
            : searchInputBox.val().toLowerCase();

        let children = listItems.children();

        if (key === '') {
            children.css('display', 'block');
        } else {

            for (let i = 0; i < children.length; i++) {
                let isMatched = isCaseSensitive
                    ? children[i].textContent.includes(key)
                    : children[i].textContent.toLowerCase().includes(key);

                let displayValue = isMatched
                    ? 'block'
                    : 'none';

                $(children[i]).css('display', displayValue);
            }
        }
    }
}