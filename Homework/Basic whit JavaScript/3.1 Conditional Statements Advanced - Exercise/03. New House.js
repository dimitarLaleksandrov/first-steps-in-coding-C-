function newHouse(input) {
    const rouse = 5.0;
    const dahlia = 3.80;
    const tulip = 2.80;
    const narcissus = 3.0;
    const gladiolus = 2.50;
    let flowerTipe = input[0];
    let numOfFlowers = Number(input[1]);
    let budget = Number(input[2]);
    let flowersPrice = 0;
    let price = 0;
    switch (flowerTipe) {
        case "Roses":
            price = numOfFlowers * rouse;
            if (numOfFlowers > 80) {
                flowersPrice = price - (price * 0.10);
            } else {
                flowersPrice = price;
            }
            break;
        case "Dahlias":
            price = numOfFlowers * dahlia;
            if (numOfFlowers > 90) {
                flowersPrice = price - (price * 0.15);
            } else {
                flowersPrice = price;
            }
            break;
        case "Tulips":
            price = numOfFlowers * tulip;
            if (numOfFlowers > 80) {
                flowersPrice = price - (price * 0.15);
            } else {
                flowersPrice = price;
            }
            break;
        case "Narcissus":
            price = numOfFlowers * narcissus;
            if (numOfFlowers < 120) {
                flowersPrice = price + (price * 0.15);
            } else {
                flowersPrice = price;
            }
            break;
        case "Gladiolus":
            price = numOfFlowers * gladiolus;
            if (numOfFlowers < 80) {
                flowersPrice = price + (price * 0.20);
            } else {
                flowersPrice = price;
            }
            break;
        default:
            break;
    }
    if (budget >= flowersPrice) {
        let moneyLeft = budget - flowersPrice;
        console.log(`Hey, you have a great garden with ${numOfFlowers} ${flowerTipe} and ${moneyLeft.toFixed(2)} leva left.`);
    } else {
        let moneyNeed = flowersPrice - budget;
        console.log(`Not enough money, you need ${moneyNeed.toFixed(2)} leva more.`);
    }
}