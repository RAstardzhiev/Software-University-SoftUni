function processQuartzOre(params) {
    let targetThickness = params[0];

    // Define operations
    let operations = {
        cut: {
            name: 'Cut',
            action: (n) => n / 4.0,
            performedCount: 0
        },
        lap: {
            name: 'Lap',
            action: (n) => n * 0.8,
            performedCount: 0
        },
        grind: {
            name: 'Grind',
            action: (n) => n - 20,
            performedCount: 0
        },
        etch: {
            name: 'Etch',
            action: (n) => n - 2,
            performedCount: 0
        },
        xray: {
            name: 'X-ray',
            action: (n) => n + 1,
            performedCount: 0
        },
        transportingAndWashing: {
            name: 'Transporting and washing',
            action: (n) => Math.floor(n)
        }
    }

    // Loop through eac Raw material
    for (let i = 1; i < params.length; i++) {
        let currentThickness = params[i];
        shapeCrystal(targetThickness, currentThickness);
    }

    function shapeCrystal(targetThickness, currentThickness) {
        let resultingMessage = `Processing chunk ${currentThickness} microns`;
        let lastOperation = '';

        while (true) {
            // Check if it is ready
            if (Math.floor(currentThickness) == targetThickness) {
                operationChange();
                break;
            }else if (currentThickness < targetThickness) {
                operationChange();
                currentThickness = operations.xray.action(currentThickness);
                resultingMessage += '\r\nX-ray x1';
                break;
            }

            // Calculate rough operatiuons
            let cutted = operations.cut.action(currentThickness);
            let lapped = operations.lap.action(currentThickness);
            let grinded = operations.grind.action(currentThickness);
            let etched = operations.etch.action(currentThickness);

            // Choose the best operation 
            if (cutted >= targetThickness - 1 && cutted < lapped && cutted < grinded && cutted < etched) {
                currentThickness = cutted;
                operations.cut.performedCount++;
                if (lastOperation !== operations.cut.name) {
                    operationChange();
                    lastOperation = operations.cut.name;
                }
            } else if (lapped >= targetThickness - 1 && lapped < grinded && lapped < etched) {
                currentThickness = lapped;
                operations.lap.performedCount++;
                if (lastOperation !== operations.lap.name) {
                    operationChange();
                    lastOperation = operations.lap.name;
                }
            } else if (grinded >= targetThickness - 1 && grinded < etched){
                currentThickness = grinded;
                operations.grind.performedCount++;
                if (lastOperation !== operations.grind.name) {
                    operationChange();
                    lastOperation = operations.grind.name;
                }
            } else {
                currentThickness = etched;
                operations.etch.performedCount++;
                if (lastOperation !== operations.etch.name) {
                    operationChange();
                    lastOperation = operations.etch.name;
                }
            }

            function operationChange() {
                if (lastOperation !== '') {
                    resultingMessage += `\r\n${operations[lastOperation.toLowerCase()].name} x${operations[lastOperation.toLowerCase()].performedCount}`;
                    operations[lastOperation.toLowerCase()].performedCount = 0;
                    currentThickness = operations.transportingAndWashing.action(currentThickness);
                    resultingMessage += '\r\nTransporting and washing';
                }
            }
        }

        // Print the result
        resultingMessage += `\r\nFinished crystal ${currentThickness} microns`;
        console.log(resultingMessage);
    }
}

processQuartzOre([1375, 50000]);
console.log();
processQuartzOre([1000, 4000, 8100]);
