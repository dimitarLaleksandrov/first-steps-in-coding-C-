function evenPowersOf2(input) {
    let num = Number(input[0]);
    let number = 1;
    for (let i = 0; i <= num; i += 2) {
        console.log(number);
        number = number * 2 * 2;
    }
}
evenPowersOf2(["6"])