function acountBalance(input) {
    let index = 0;
    let totalMoney = 0;
    let text = input[index];
    while (text !== "NoMoreMoney") {
        let money = Number(input[index]);
        if (money < 0) {
            console.log("Invalid operation!")
            break;
        }
        console.log(`Increase: ${money.toFixed(2)}`);
        totalMoney += money;
        index++;
        text = input[index];
    }
    console.log(`Total: ${totalMoney.toFixed(2)}`);
}