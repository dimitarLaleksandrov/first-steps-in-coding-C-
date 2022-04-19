function coins(input) {
    let money = Number(input[0]);
    let coins = Math.floor(money * 100);
    let coinCounter = 0;
    while (coins > 0) {
        if (coins >= 200) {
            coins -= 200;
            coinCounter++;
            continue;
        }
        if (coins >= 100) {
            coins -= 100;
            coinCounter++;
            continue;
        }
        if (coins >= 50) {
            coins -= 50;
            coinCounter++;
            continue;
        }
        if (coins >= 20) {
            coins -= 20;
            coinCounter++;
            continue;
        }
        if (coins >= 10) {
            coins -= 10;
            coinCounter++;
            continue;
        }
        if (coins >= 5) {
            coins -= 5;
            coinCounter++;
            continue;
        }
        if (coins >= 2) {
            coins -= 2;
            coinCounter++;
            continue;
        }
        if (coins >= 1) {
            coins -= 1;
            coinCounter++;
        }
    }
    console.log(coinCounter);
}