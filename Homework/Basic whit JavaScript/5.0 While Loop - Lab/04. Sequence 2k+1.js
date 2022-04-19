function sequence2k(input) {
    let num = input[0];
    let index = 0;
    let numbers = 0;
    while (numbers <= num) {
        numbers = index * 2 + 1;
        index = numbers;
        if (numbers > num) {
            break;
        }
        console.log(numbers);
    }
}