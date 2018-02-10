function printAirplanesStat(params) {
    let airports = new Map();
    let planes = [];

    // Validate input
    for (const line of params) {
        let lineTokens = line.split(' ');
        let id = lineTokens[0];
        let town = lineTokens[1];
        let passengers = Number(lineTokens[2]);
        let action = lineTokens[3];

        if (action === 'land') {
            let currentPlane = planes.filter(p => p.id === id)[0];
            if (!currentPlane) {
                currentPlane = { id: id, landingAirport: town };
                planes.push(currentPlane);
            } else if (!currentPlane.landingAirport) {
                currentPlane.landingAirport = town;
            } else {
                continue;
            }

            let currentAirport = getAirport(town);
            currentAirport.arrivals += passengers;
            currentAirport.planes.add(currentPlane.id);
        } else if (action === 'depart') {
            let currentPlane = planes.filter(p => p.id === id)[0];
            if (!currentPlane || currentPlane.landingAirport === null) {
                continue;
            }

            currentPlane.landingAirport = null;

            let currentAirport = getAirport(town);
            currentAirport.departures += passengers;
            currentAirport.planes.add(currentPlane.id);
        }
    }

    // Print stat
    // Landing Planes Stat
    let result = 'Planes left:\n';
    let landingPlanes = planes.filter(p => p.landingAirport != null);
    if (landingPlanes.length > 0) {
        result += '- ' + landingPlanes
            .map(p => p.id)
            .sort((a, b) => a.localeCompare(b))
            .join('\n- ') + '\n';
    }

    // Airports stat
    // Up To: The IDs of planes that remain at our airport (their last valid action is land). Sort them alphabetically
    for (const [town, stat] of [...airports].sort((a, b) => {
        let byNumberOfArrivals = b[1].arrivals - a[1].arrivals;
        return byNumberOfArrivals !== 0 ? byNumberOfArrivals // Descending
            : a[0] < b[0] ? -1 : a[0] > b[0] ? 1 : 0; // By name Ascending
    })) {
        result += town + '\n' +
            `Arrivals: ${stat.arrivals}\n` +
            `Departures: ${stat.departures}\n` +
            'Planes:\n' +
            '-- ' + [...stat.planes]
                .sort((a, b) => a.localeCompare(b))
                .join('\n-- ') + '\n';
    }

    console.log(result.trim());

    function getAirport(town) {
        let currentAirport = airports.get(town);
        if (!currentAirport) {
            airports.set(town, { arrivals: 0, departures: 0, planes: new Set() });
        }

        return airports.get(town);
    }
}

printAirplanesStat(
    [
        "Airbus Paris 100 land ",
        "AirForce Paris 200 land ",
        "Airbus Paris -300 land ",
        "AirForcE Paris 100 land ",
        "AirForce London 100 land ",
        "AirFoRce LoNdon 130 land ",
        "Nemibue London 150 land ",
        "Nemibue London 150 depart"
    ]
);

// printAirplanesStat(
//     [
//         "Boeing474 Madrid 300 land",
//         "AirForceOne WashingtonDC 178 land",
//         "Airbus London 265 depart",
//         "ATR72 WashingtonDC 272 land",
//         "ATR72 Madrid 135 depart"
//     ]
// );