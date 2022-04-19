function cleverLily(input) {
    let ageOfLily = Number(input[0]);
    let priceOfTheMachine = Number(input[1]);
    let toyPrice = Number(input[2]);
    let money = 0;
    let toyNum = 0;
    for (let i = 1; i <= ageOfLily; i++) {
        if (i % 2 === 0) {
            money += 10 * (i / 2) - 1;
        } else {
            toyNum += 1;
        }
    }
    let allToyPrice = toyPrice * toyNum;
    let allMoney = allToyPrice + money;
    if (allMoney >= priceOfTheMachine) {
        let moneyLeft = allMoney - priceOfTheMachine;
        console.log(`Yes! ${moneyLeft.toFixed(2)}`);
    } else {
        let notEnoughAmount = priceOfTheMachine - allMoney;
        console.log(`No! ${notEnoughAmount.toFixed(2)}`);
    }
}