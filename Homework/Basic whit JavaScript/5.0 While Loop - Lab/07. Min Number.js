function minNum(input) {
    let minNum;
    let index = 0;
    let command = input[index];
    while (command !== "Stop") {
        let num = Number(input[index]);
        if (num > minNum) {
            minNum = minNum;
        } else {
            minNum = num;
        }
        index++;
        command = input[index];
    }
    console.log(minNum);
}