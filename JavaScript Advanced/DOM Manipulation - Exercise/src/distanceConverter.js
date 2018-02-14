function attachEventsListeners() {
    let button = document.getElementById('convert');
    button.addEventListener('click', convert);

    // Get working references
    let inputBox = document.getElementById('inputDistance');
    let outputBox = document.getElementById('outputDistance');

    let inputUnits = document.getElementById('inputUnits');
    let outputUnits = document.getElementById('outputUnits');

    // Define Conversions
    let conversions = {
        km: {
            km: n => n,
            m: n => n * 1000,
            cm: n => n * 1000 * 100,
            mm: n => n * 1000 * 100 * 10,
            mi: n => n * 1000 / 1609.34,
            yrd: n => n * 1000 / 0.9144,
            ft: n => n * 1000 / 0.3048,
            in: n => n * 1000 / 0.0254
        },
        m: {
            km: n => n / 1000,
            m: n => n,
            cm: n => n * 100,
            mm: n => n * 1000,
            mi: n => n / 1609.34,
            yrd: n => n / 0.9144,
            ft: n => n / 0.3048,
            in: n => n / 0.0254
        },
        cm: {
            km: n => n / 100 / 1000,
            m: n => n / 100,
            cm: n => n,
            mm: n => n * 10,
            mi: n => n / 100 / 1609.34,
            yrd: n => n / 100 / 0.9144,
            ft: n => n / 100 / 0.3048,
            in: n => n / 100 / 0.0254
        },
        mm: {
            km: n => n * 0.001 / 1000,
            m: n => n * 0.001,
            cm: n => n / 10,
            mm: n => n,
            mi: n => n * 0.001 / 1609.34,
            yrd: n => n * 0.001 / 0.9144,
            ft: n => n * 0.001 / 0.3048,
            in: n => n * 0.001 / 0.0254
        },
        mi: {
            km: n => n * 1609.34 / 1000,
            m: n => n * 1609.34,
            cm: n => n * 1609.34 * 100,
            mm: n => n * 1609.34 * 1000,
            mi: n => n,
            yrd: n => n * 1609.34 / 0.9144,
            ft: n => n * 1609.34 / 0.3048,
            in: n => n * 1609.34 / 0.0254
        },
        yrd: {
            km: n => n * 0.9144 / 1000,
            m: n => n * 0.9144,
            cm: n => n * 0.9144 * 100,
            mm: n => n * 0.9144 * 1000,
            mi: n => n * 0.9144 / 1609.34,
            yrd: n => n,
            ft: n => n * 0.9144 / 0.3048,
            in: n => n * 0.9144 / 0.0254
        },
        ft: {
            km: n => n * 0.3048 / 1000,
            m: n => n * 0.3048,
            cm: n => n * 0.3048 * 100,
            mm: n => n * 0.3048 * 1000,
            mi: n => n * 0.3048 / 1609.34,
            yrd: n => n * 0.3048 / 0.9144,
            ft: n => n,
            in: n => n * 0.3048 / 0.0254
        }, 
        in: {
            km: n => n * 0.0254 / 1000,
            m: n => n * 0.0254,
            cm: n => n * 0.0254 * 100,
            mm: n => n * 0.0254 * 1000,
            mi: n => n * 0.0254 / 1609.34,
            yrd: n => n * 0.0254 / 0.9144,
            ft: n => n * 0.0254 / 0.3048,
            in: n => n
        }
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

        let fromUnit = conversions[inputUnits.value];
        if (!fromUnit) {
            return;
        }

        let convertingFunc = fromUnit[outputUnits.value];
        if (!convertingFunc) {
            return;
        }

        let result = convertingFunc(value);
        outputBox.value = result;
    }
}