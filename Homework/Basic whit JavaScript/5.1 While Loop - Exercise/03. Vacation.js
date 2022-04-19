function vacation(input) {
    let moneyForTheTrip = Number(input[0]);
    let money = Number(input[1]);
    let index = 2;
    let spendDayCounter = 0;
    let command;
    let moneyAddOrSpend = 0;
    let dayCounter = 0;
    while (money < moneyForTheTrip) {
        command = input[index];
        index++;
        moneyAddOrSpend = Number(input[index]);
        index++
        dayCounter++;
        if (command === "spend") {
            money -= moneyAddOrSpend;
            spendDayCounter++;
            if (money < 0) {
                money = 0;
            }
            if (spendDayCounter === 5) {
                console.log(`You can't save the money.`);
                console.log(`${dayCounter}`);
                break;
            }
        } else if (command === "save") {
            money += moneyAddOrSpend;
            spendDayCounter = 0;
        }
    }
    if (spendDayCounter !== 5) {
        console.log(`You saved the money for ${dayCounter} days.`);
    }
}