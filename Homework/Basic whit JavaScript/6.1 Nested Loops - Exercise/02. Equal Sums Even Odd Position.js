function equalSums(input) {
    let firstNum = Number(input[0]);
    let secondNum = Number(input[1]);
    let printLine = "";
    for (let i = firstNum; i <= secondNum; i++) {
        let curentNum = "" + i;
        let odd = 0;
        let even = 0;
        for (let j = 0; j <= curentNum.length; j++) {
            let digit = Number(curentNum.charAt(j));
            if (j % 2 === 0) {
                even += digit;
            } else {
                odd += digit;
            }
        }
        if (odd === even) {
            printLine += `${i}` + " ";
        }
    }
    console.log(printLine);
}