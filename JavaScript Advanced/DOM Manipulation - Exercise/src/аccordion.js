function toggle() {
    let button = document.querySelector('span.button');
    let currentState = button.textContent;
    let targetDiv = document.getElementById('extra');

    if (currentState === 'More') {
        more();
    } else {
        less();
    }

    function more() {
        button.textContent = 'Less';
        targetDiv.style.display = 'block';
    }

    function less() {
        button.textContent = 'More';
        targetDiv.style.display = 'none';
    }
}