function fishingBoat(input) {
    const springBoatPrise = 3000;
    const summerBoatPrice = 4200;
    const autumnBoatPrice = 4200;
    const winterBoatPrice = 2600;
    let buget = Number(input[0]);
    let season = input[1];
    let numOfFisherman = Number(input[2]);
    let moneyNeed = 0;
    switch (season) {
        case "Spring":
            if (numOfFisherman <= 6) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = springBoatPrise - (springBoatPrise * 0.15);
                } else {
                    moneyNeed = springBoatPrise - (springBoatPrise * 0.10);
                }
            } else if (numOfFisherman >= 7 && numOfFisherman <= 11) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = springBoatPrise - (springBoatPrise * 0.20);
                } else {
                    moneyNeed = springBoatPrise - (springBoatPrise * 0.15);
                }
            } else if (numOfFisherman >= 12) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = springBoatPrise - (springBoatPrise * 0.30);;
                } else {
                    moneyNeed = springBoatPrise - (springBoatPrise * 0.25);
                }
            }
            if (buget >= moneyNeed) {
                let moneyLeft = buget - moneyNeed;
                console.log(`Yes! You have ${moneyLeft.toFixed(2)} leva left.`);
            } else {
                moneyLeft = moneyNeed - buget;
                console.log(`Not enough money! You need ${moneyLeft.toFixed(2)} leva.`)
            }
            break;
        case "Summer":
            if (numOfFisherman <= 6) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = summerBoatPrice - (summerBoatPrice * 0.15);
                } else {
                    moneyNeed = summerBoatPrice - (ssummerBoatPrice * 0.10);
                }
            } else if (numOfFisherman >= 7 && numOfFisherman <= 11) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = summerBoatPrice - (summerBoatPrice * 0.20);
                } else {
                    moneyNeed = summerBoatPrice - (summerBoatPrice * 0.15);
                }
            } else if (numOfFisherman >= 12) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = summerBoatPrice - (summerBoatPrice * 0.30);;
                } else {
                    moneyNeed = summerBoatPrice - (summerBoatPrice * 0.25);
                }
            }
            if (buget >= moneyNeed) {
                let moneyLeft = buget - moneyNeed;
                console.log(`Yes! You have ${moneyLeft.toFixed(2)} leva left.`);
            } else {
                moneyLeft = moneyNeed - buget;
                console.log(`Not enough money! You need ${moneyLeft.toFixed(2)} leva.`)
            }
            break;
        case "Autumn":
            if (numOfFisherman <= 6) {
                moneyNeed = autumnBoatPrice - (autumnBoatPrice * 0.10);
            } else if (numOfFisherman >= 7 && numOfFisherman <= 11) {
                moneyNeed = autumnBoatPrice - (autumnBoatPrice * 0.15);
            } else if (numOfFisherman >= 12) {
                moneyNeed = autumnBoatPrice - (autumnBoatPrice * 0.25);
            }
            if (buget >= moneyNeed) {
                let moneyLeft = buget - moneyNeed;
                console.log(`Yes! You have ${moneyLeft.toFixed(2)} leva left.`);
            } else {
                moneyLeft = moneyNeed - buget;
                console.log(`Not enough money! You need ${moneyLeft.toFixed(2)} leva.`)
            }
            break;
        case "Winter":
            if (numOfFisherman <= 6) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = winterBoatPrice - (winterBoatPrice * 0.15);
                } else {
                    moneyNeed = winterBoatPrice - (winterBoatPrice * 0.10);
                }
            } else if (numOfFisherman >= 7 && numOfFisherman <= 11) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = winterBoatPrice - (winterBoatPrice * 0.20);
                } else {
                    moneyNeed = winterBoatPrice - (winterBoatPrice * 0.15);
                }
            } else if (numOfFisherman >= 12) {
                if (numOfFisherman % 2 == 0) {
                    moneyNeed = winterBoatPrice - (winterBoatPrice * 0.30);;
                } else {
                    moneyNeed = winterBoatPrice - (winterBoatPrice * 0.25);
                }
            }
            if (buget >= moneyNeed) {
                let moneyLeft = buget - moneyNeed;
                console.log(`Yes! You have ${moneyLeft.toFixed(2)} leva left.`);
            } else {
                moneyLeft = moneyNeed - buget;
                console.log(`Not enough money! You need ${moneyLeft.toFixed(2)} leva.`)
            }
            break;
        default:
            break;
    }
}