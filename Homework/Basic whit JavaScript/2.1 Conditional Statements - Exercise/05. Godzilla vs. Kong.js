function godzillaVsKong(input) {
    let budget = Number(input[0]);
    let statistNum = Number(input[1]);
    let priceOfEachClothing = Number(input[2]);
    let decor = budget * 0.10;
    let clothingPrice = statistNum * priceOfEachClothing;
    if (statistNum > 150) {
        clothingPrice -= clothingPrice * 0.10;
    }
    let priceForTheFilm = decor + clothingPrice;
    if (priceForTheFilm > budget) {
        let moneyNeed = priceForTheFilm - budget;
        console.log("Not enough money!");
        console.log(`Wingard needs ${moneyNeed.toFixed(2)} leva more.`);
    } else {
        let moneyLeft = budget - priceForTheFilm;
        console.log("Action!");
        console.log(`Wingard starts filming with ${moneyLeft.toFixed(2)} leva left.`)
    }
}