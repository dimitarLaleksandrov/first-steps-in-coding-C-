function maxNum(input) {
    let maxNum;
    let index = 0;
    let command = input[index];
    while (command !== "Stop") {
        let num = Number(input[index]);
        if (num < maxNum) {
            maxNum = maxNum;
        } else {
            maxNum = num;
        }
        index++;
        command = input[index];
    }
    console.log(maxNum);
}