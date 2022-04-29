function amazingNum(input) {
    input = input.toString();
    let sum = 0;
    for (let i = 0; i < input.length; i++) {
        sum += Number(input[i]);
    }
    let resolt = sum.toString().includes('9');
    console.log(resolt ? `${input} Amazing? True` : `${input} Amazing? False`);
}
amazingNum(999)