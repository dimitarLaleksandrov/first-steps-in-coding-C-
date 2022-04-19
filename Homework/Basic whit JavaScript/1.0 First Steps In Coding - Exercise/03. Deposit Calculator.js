function calculatorForDeposit(input) {
    let deposit = Number(input[0]);
    let term = Number(input[1]);
    let annualRate = Number(input[2]);
    let interest = deposit * (annualRate / 100);
    let interestForMonth = interest / 12;
    let sum = deposit + term * interestForMonth;
    console.log(sum);
}