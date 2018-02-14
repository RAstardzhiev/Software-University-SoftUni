function addItem() {
    let inputText = document.getElementById('newItemText');
    let inputValue = document.getElementById('newItemValue');

    let textContent = inputText.value;
    inputText.value = '';

    let valueContent = inputValue.value;
    inputValue.value = '';

    let option = document.createElement('option');
    option.value = valueContent;
    option.textContent = textContent;

    let menu = document.getElementById('menu');
    menu.appendChild(option);
}