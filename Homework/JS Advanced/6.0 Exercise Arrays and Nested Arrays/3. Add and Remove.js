function addemove(arr) {
    let array = [];
    let index = 1;
    for (let iArr of arr) {
        switch (iArr) {
            case `add`:
                array.push(index);
                index++;
                break;
            case `remove`:
                array.pop(index);
                index++;
                break;
            default:
                break;
        }
    }
    if (array.length === 0) {
        console.log(`Empty`);
    } else {
        for (let arr of array) {
            console.log(arr);
        }
    }

}
addemove(['add',
    'add',
    'add',
    'add'
]);
addemove(['add',
    'add',
    'remove',
    'add',
    'add'
]);
addemove(['remove',
    'remove',
    'remove'
]);