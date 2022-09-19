function rotateArray(arr, num) {
    let array = [];
    array = arr;
    for (let i = 0; i < num; i++) {
        let el = array.shift();
        array.push(el);
    }
    console.log(array.join(" "));
}
rotateArray(['Banana',
        'Orange',
        'Coconut',
        'Apple'
    ],
    15);