function printTableAsJson(params) {
    let towns = [];

    for (let i = 1; i < params.length; i++) {
        let [town, latitude, longitude] = params[i]
            .split('|')
            .filter(e => e !== '')
            .map(e => e.trim());

        towns.push({
            Town: town,
            Latitude: Number(latitude),
            Longitude: Number(longitude)
        });
    }

    console.log(JSON.stringify(towns));
}

printTableAsJson(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
);