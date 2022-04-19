function shopping(input) {
    const videocardsPrice = 250;
    let buget = Number(input[0]);
    let numVideocards = Number(input[1]);
    let numOfProcesors = Number(input[2]);
    let ramNum = Number(input[3]);
    let priceOfVideocard = numVideocards * videocardsPrice;
    let procesorPrice = priceOfVideocard * 0.35;
    let procesurSum = numOfProcesors * procesorPrice;
    let ramPrice = priceOfVideocard * 0.10;
    let ramSum = ramNum * ramPrice;
    let allSum = procesurSum + priceOfVideocard + ramSum;
    if (numVideocards > numOfProcesors) {
        allSum -= allSum * 0.15;
    }
    if (buget >= allSum) {
        let leftMoney = buget - allSum;
        console.log(`You have ${leftMoney.toFixed(2)} leva left!`)
    } else {
        let moneyNeed = allSum - buget;
        console.log(`Not enough money! You need ${moneyNeed.toFixed(2)} leva more!`)
    }
}