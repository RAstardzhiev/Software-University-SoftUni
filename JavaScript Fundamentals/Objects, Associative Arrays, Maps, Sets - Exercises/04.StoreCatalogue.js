function productsTOCatalog(params) {
    let products = params
        .map(e => {
            let tokens = e.split(' : ');
            return { name: tokens[0], price: Number(tokens[1]) }
        })
        .sort((a, b) => a.name.toUpperCase() < b.name.toUpperCase() ? -1
            : a.name.toUpperCase() > b.name.toUpperCase() ? 1 : 0);

    if (products.length < 1) {
        return '';
    }

    let lastLetter = products[0].name[0].toUpperCase();
    let catalog = lastLetter + '\n';
    let ident = '  ';

    for (let i = 0; i < products.length; i++) {
        let currentLetter = products[i].name[0].toUpperCase();
        if (currentLetter !== lastLetter) {
            catalog += currentLetter + '\n';
            lastLetter = currentLetter;
        }

        catalog += `${ident}${products[i].name}: ${products[i].price}\n`
    }

    return catalog;
}

console.log(productsTOCatalog([]));
console.log(productsTOCatalog(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']
));
