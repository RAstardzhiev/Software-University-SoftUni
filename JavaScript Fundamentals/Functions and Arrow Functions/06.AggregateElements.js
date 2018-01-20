function printAggregation(params) {
    function aggregate(initialValue, func) {
        let result = initialValue;

        for (num of params) {
            result = func(result, num);
        }

        return result;
    }

    console.log(aggregate(0, (result, num) => result + num));
    console.log(aggregate(0, (result, num) => result + 1 / num));
    console.log(aggregate('', (result, num) => result + num));
}

printAggregation([1, 2, 3]);