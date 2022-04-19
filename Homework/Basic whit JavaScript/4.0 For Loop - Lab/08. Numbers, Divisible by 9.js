function numDivisibleBy9(input) {
    let startNum = Number(input[0]);
    let endNum = Number(input[1]);
    let sum = 0;
    for (let i = startNum; i <= endNum; i++) {
        if (i % 9 === 0) {
            sum += i;
        }
    }
    console.log(`The sum: ${sum}`);
    for (let i = startNum; i <= endNum; i++) {
        if (i % 9 === 0) {
            console.log(i);
        }
    }
}