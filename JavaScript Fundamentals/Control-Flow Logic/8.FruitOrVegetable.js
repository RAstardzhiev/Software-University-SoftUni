function fruitOrVegetable(name) {
    let fruits = [ 'banana', 'apple', 'kiwi', 'cherry', 'lemon', 'grapes', 'peach' ];
    let vegetables = [ 'tomato', 'cucumber', 'pepper', 'onion', 'garlic', 'parsley' ];

    let result = fruits.indexOf(name) >= 0 ? 'fruit'
        : vegetables.indexOf(name) >= 0 ? 'vegetable'
        : 'unknown';

    console.log(result);
}

fruitOrVegetable('apple');