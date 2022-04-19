function sumNumbers(input) {
    let numToReach = input[0];
    let index = 1;
    let num = 0;
    while ((num += Number(input[index])) < numToReach) {
        index++;
    }
    console.log(num);
}