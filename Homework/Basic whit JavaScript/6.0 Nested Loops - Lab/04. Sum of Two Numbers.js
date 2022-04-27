function sumOfTwoNums(input) {
    let startNum = Number(input[0]);
    let endNum = Number(input[1]);
    let magicNum = Number(input[2]);
    let counter = 0;
    let furstCombo = 0;
    let isItfaund = false;
    let furstNum = 0;
    let secondNum = 0;
    for (i = startNum; i <= endNum; i++) {
        for (j = startNum; j <= endNum; j++) {
            counter++;
            if (i + j === magicNum) {
                furstCombo = counter;
                isItfaund = true;
                furstNum = i;
                secondNum = j;
                break;
            }
        }
        if (isItfaund) {
            break;
        }
    }
    if (furstCombo !== 0) {
        console.log(`Combination N:${furstCombo} (${furstNum} + ${secondNum} = ${magicNum})`);
    } else {
        console.log(`${counter} combinations - neither equals ${magicNum}`);
    }
}