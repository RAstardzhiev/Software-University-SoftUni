function create(sentences) {
    let container = document.getElementById('content');

    for (const line of sentences) {
        let paragraph = document.createElement('p');
        paragraph.textContent = line;
        paragraph.style.display = 'none';

        let currentDiv = document.createElement('div');
        currentDiv.appendChild(paragraph);
        currentDiv.addEventListener('click', displayChildren);

        container.appendChild(currentDiv);
    }

    function displayChildren() {
        let currentParagraph = this.firstChild;
        currentParagraph.style.display = 'inline';
    }
}