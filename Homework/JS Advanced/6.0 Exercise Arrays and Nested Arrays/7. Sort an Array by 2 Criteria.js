function sortanArray(input) {
    let sortArray = input.sort((a, b) => {
        if (a.length !== b.length) {
            return a.length - b.length;
        } else {
            return a.localeCompare(b);
        }
    });
    console.log(sortArray.join(`\n`));
    //input.sort((a,b) => a.length !== b.length ?  a.length - b.length : a.localeCompare(b)).join(`\n`);
}
sortanArray(['alpha',
    'beta',
    'gamma'
]);