function toyShop(input) {
    const puzzel = 2.60;
    const dalls = 3;
    const teddybear = 4.10;
    const miniuns = 8.20;
    const truks = 2;
    let travelCost = Number(input[0]);
    let puzzelNumber = Number(input[1]);
    let dallsNumber = Number(input[2]);
    let teddybearNumber = Number(input[3]);
    let miniunsNumber = Number(input[4]);
    let truksNumber = Number(input[5]);
    let toysOrderedNumber = puzzelNumber + dallsNumber + teddybearNumber + miniunsNumber + truksNumber;
    let allPrice = (puzzelNumber * puzzel) + (dallsNumber * dalls) + (teddybearNumber * teddybear) + (miniunsNumber * miniuns) + (truksNumber * truks);
    if (toysOrderedNumber >= 50) {
        allPrice = allPrice - (allPrice * 0.25);
    }
    let rent = allPrice * 0.10;
    let profit = allPrice - rent;
    if (profit >= travelCost) {
        let moneyAfterTravelCost = profit - travelCost;
        console.log(`Yes! ${moneyAfterTravelCost.toFixed(2)} lv left.`)
    } else {
        let moneyAfterTravelCost = travelCost - profit;
        console.log(`Not enough money! ${moneyAfterTravelCost.toFixed(2)} lv needed.`)
    }
}