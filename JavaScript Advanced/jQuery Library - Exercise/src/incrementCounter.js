function increment(selector) {
    let container = $(selector);

    // Get needed references
    let textArea = $('<textarea>')
        .addClass('counter')
        .val('0')
        .attr('disabled', true);

    let unorderedList = $('<ul>')
        .addClass('results');

    // Append initial elements
    container.append(
        textArea,
        // $('<button>', { class: 'btn', id: 'incrementBtn', text: 'Increment' }) // Works the same way
        $('<button class="btn" id="incrementBtn">Increment</button>')
            .click(() => textArea.val(Number(textArea.val()) + 1)),
        $('<button class="btn" id="addBtn">Add</button>')
            .click(() => unorderedList.append($('<li>').text(textArea.val()))),
        unorderedList
    );
}