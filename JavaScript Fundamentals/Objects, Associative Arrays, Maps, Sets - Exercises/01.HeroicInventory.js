let heroInventoryToJson = params => JSON.stringify(params
    .map(e => e.split(' / '))
    .map(e => {
        return {
            name: e[0],
            level: Number(e[1]),
            items: !e[2]
                ? []
                : e[2].split(', ')
        }
    }));

console.log(heroInventoryToJson(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara', 
    'Test / 12 / ']
));
