function printEveryN(array, num) {
    let arr = [];
    for (let i = 0; i < array.length; i += num) {
        arr.push(array[i]);
    }
    return arr;
}
printEveryN(['5',
        '20',
        '31',
        '4',
        '20'
    ],
    2);