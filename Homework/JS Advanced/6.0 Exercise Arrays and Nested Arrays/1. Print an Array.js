function printArray(array, delitel) {
    let arr = array[0];
    for (let i = 1; i < array.length; i++) {
        arr += delitel + array[i];
    }
    console.log(arr);
}
printArray(['One',
        'Two',
        'Three',
        'Four',
        'Five'
    ],
    '-');