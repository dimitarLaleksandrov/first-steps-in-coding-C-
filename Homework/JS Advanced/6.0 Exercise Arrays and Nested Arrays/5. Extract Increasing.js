function extractIncreasing(input) {
    let array = [];
    array.push(input[0]);
    let bigetsInt = input[0];
    for (let i = 1; i < input.length; i++) {
        if (bigetsInt <= input[i]) {
            array.push(input[i]);
            bigetsInt = input[i];
        }
    }
    return array;
}
extractIncreasing([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24
]);