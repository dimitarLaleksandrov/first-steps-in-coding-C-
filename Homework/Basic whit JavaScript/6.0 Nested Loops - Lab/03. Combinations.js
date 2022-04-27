function combinations(input) {
    let numToValidait = Number(input[0]);
    let counter = 0;
    for (let i = 0; i <= numToValidait; i++) {
        for (j = 0; j <= numToValidait; j++) {
            for (h = 0; h <= numToValidait; h++) {
                if (i + j + h === numToValidait) {
                    counter++;
                }
            }
        }
    }
    console.log(counter);
}