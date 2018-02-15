function attachEventsListeners() {
    let button = document.getElementById('convert');
    button.addEventListener('click', convert);

    // Get working references
    let inputBox = document.getElementById('inputDistance');
    let outputBox = document.getElementById('outputDistance');

    let inputUnits = document.getElementById('inputUnits');
    let outputUnits = document.getElementById('outputUnits');

    // Define Conversions
    let meterBasedRates = {
        km: 1000,
        m: 1,
        cm: 0.01,
        mm: 0.001,
        mi: 1609.34,
        yrd: 0.9144,
        ft: 0.3048,
        in: 0.0254
    }

    function convert() {
        // Get input as number
        let rawValue = inputBox.value.trim();
        if (rawValue === '') {
            return;
        }

        let value = Number(rawValue);
        if (isNaN(value)) {
            return;
        }

        let fromRate = meterBasedRates[inputUnits.value];
        let targetRate = meterBasedRates[outputUnits.value]
        if (!fromRate || !targetRate) {
            return;
        }

        let result = value * fromRate / targetRate;
        outputBox.value = result;
    }
}