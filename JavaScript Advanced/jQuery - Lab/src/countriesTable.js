function initializeTable() {
    // Create button event
    $('a#createLink').click(addTableRow);

    // Get needed references
    let countryInputBox = $('input#newCountryText');
    let capitalInputBox = $('input#newCapitalText');
    let rowsContainer = countryInputBox
        .parent()
        .parent()
        .parent();

    // Set initial rows
    createTableRow('Bulgaria', 'Sofia');
    createTableRow('Germany', 'Berlin');
    createTableRow('Russia', 'Moscow');

    // Fix Row Links
    fixRowLinks();

    function addTableRow() {
        let countryName = countryInputBox.val();
        countryInputBox.val('');

        let capitalName = capitalInputBox.val();
        capitalInputBox.val('');

        createTableRow(countryName, capitalName);
        fixRowLinks();
    }

    function createTableRow(country, capital) {
        country = country.trim();
        capital = capital.trim();
        if (country.length === 0 || capital.length === 0) {
            return;
        }

        rowsContainer.append($('<tr>')
            .append($('<td>').text(country))
            .append($('<td>').text(capital))
            .append($('<td>')
                .append($('<a href="#">[Up]</a>').click(rowUp))
                .append(' ')
                .append($('<a href="#">[Down]</a>').click(rowDown))
                .append(' ')
                .append($('<a href="#">[Delete]</a>').click(deleteRow))
            ).css('display', 'none')
            .fadeIn());
    }

    function rowUp() {
        let currentRow = $(this).parent().parent();

        currentRow.fadeOut(() => {
            currentRow.insertBefore(currentRow.prev());
            currentRow.fadeIn();
            fixRowLinks();
        });
    }

    function rowDown() {
        let currentRow = $(this).parent().parent();

        currentRow.fadeOut(() => {
            currentRow.insertAfter(currentRow.next());
            currentRow.fadeIn();
            fixRowLinks();
        });
    }

    function deleteRow() {
        let currentRow = $(this).parent().parent();

        currentRow.fadeOut(() => {
            currentRow.remove();
            fixRowLinks();
        });
    }

    function fixRowLinks() {
        // Make all links visible
        rowsContainer.children()
            .find('a')
            .css('display', 'inline');

        // Hide first row Up link
        rowsContainer.children()
            .eq(2)
            .find('a:contains("Up")')
            .css('display', 'none');

        // Hide last row Down link
        rowsContainer.children()
            .last()
            .find('a:contains("Down")')
            .css('display', 'none');
    }
}