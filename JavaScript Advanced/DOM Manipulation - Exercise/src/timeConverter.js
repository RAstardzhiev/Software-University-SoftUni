function attachEventsListeners() {
    let divs = document.getElementsByTagName('div');

    // Define functions map
    let functions = {
        days: (nummericValue) => daysBtn(nummericValue),
        hours: (nummericValue) => hoursBtn(nummericValue),
        minutes: (nummericValue) => minutesBtn(nummericValue),
        seconds: (nummericValue) => secondsBtn(nummericValue)
    }
    
    let getInputBox = parent => parent.getElementsByTagName('input')[0];

    // Input references
    let inputBoxes = {};

    for (const element of divs) {
        // Attach Events
        element.lastElementChild.addEventListener('click', fillTheRest);

        // Extract input references
        let currentInput = getInputBox(element)
        inputBoxes[currentInput.id] = currentInput;
    }

    function fillTheRest() {
        let currentInput = getInputBox(this.parentElement);
        let rawValue = currentInput.value.trim();
        if (rawValue === '') {
            return;
        }

        let nummericValue = Number(rawValue);
        if (isNaN(nummericValue)) {
            return;
        }

        functions[currentInput.id](nummericValue);
    }

    function daysBtn(nummericValue) {
        inputBoxes.hours.value = nummericValue * 24;
        inputBoxes.minutes.value = nummericValue * 24 * 60;
        inputBoxes.seconds.value = nummericValue * 24 * 60 * 60;
    }

    function hoursBtn(nummericValue) {
        inputBoxes.days.value = nummericValue / 24;
        inputBoxes.minutes.value = nummericValue * 60;
        inputBoxes.seconds.value = nummericValue * 60 * 60;
    }

    function minutesBtn(nummericValue) {
        inputBoxes.days.value = nummericValue / 24 / 60;
        inputBoxes.hours.value = nummericValue / 60;
        inputBoxes.seconds.value = nummericValue * 60;
    }

    function secondsBtn(nummericValue) {
        inputBoxes.days.value = nummericValue / 24 / 60 / 60;
        inputBoxes.hours.value = nummericValue / 60 / 60;
        inputBoxes.minutes.value = nummericValue / 60;
    }
}