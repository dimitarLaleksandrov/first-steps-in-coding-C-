function sameNumbers(number) {
    let toString = number.toString();
    let firstNum = Number(toString[0]);
    let isIt = false;
    let sum = 0;
    for (let i = 0; i < toString.length; i++) {
        var num = Number(toString[i]);
        sum += Number(toString[i]);
        if (firstNum === num) {
            isIt = true;
        } else {
            isIt = false;
        }
    }
    console.log(isIt);
    console.log(sum);
}
sameNumbers(1234);