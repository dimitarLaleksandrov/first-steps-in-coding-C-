function largestNumber(num1, num2, num3) {
    let largestNumber = num1
    if (num2 > num1 && num2 > num3) {
        largestNumber = num2;
    } else if (num3 > num1 && num3 > num2) {
        largestNumber = num3;
    }
    console.log(`The largest number is ${largestNumber}.`);
}
largestNumber(-3, -5, -22.5);