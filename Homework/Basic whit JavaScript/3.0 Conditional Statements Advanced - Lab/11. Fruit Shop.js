function fruitShop(input) {
    let fruitName = input[0];
    let day = input[1];
    let quantity = Number(input[2]);
    let bananaPrice = 0;
    let applePrice = 0;
    let orangePrice = 0;
    let grapefruitPrice = 0;
    let kiwiPeice = 0;
    let pineapplePrice = 0;
    let grapesPrice = 0;
    let allPrice = 0;
    switch (day) {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
            bananaPrice = 2.50;
            applePrice = 1.20;
            orangePrice = 0.85;
            grapefruitPrice = 1.45;
            kiwiPeice = 2.70;
            pineapplePrice = 5.50;
            grapesPrice = 3.85;
            switch (fruitName) {
                case "banana":
                    allPrice = bananaPrice * quantity;
                    console.log(allPrice.toFixed(2));
                    break;
                case "apple":
                    allPrice = applePrice * quantity;
                    console.log(allPrice.toFixed(2));
                    break;
                case "orange":
                    allPrice = orangePrice * quantity;
                    console.log(allPrice.toFixed(2));
                    break;
                case "grapefruit":
                    allPrice = grapesPrice * quantity;
                    console.log(allPrice.toFixed(2));
                    break;
                case "kiwi":
                    allPrice = kiwiPeice * quantity;
                    console.log(allPrice.toFixed(2));
                    break;
                case "pineapple":
                    allPrice = pineapplePrice * quantity;
                    console.log(allPrice.toFixed(2));
                    break;
                case "grapes":
                    allPrice = grapesPrice * quantity;
                    console.log(allPrice.toFixed(2));
                    break;
                default:
                    console.log("error");
                    break;
            }
            break;
        case "Saturday":
        case "Sunday":
            bananaPrice = 2.70;
            applePrice = 1.25;
            orangePrice = 0.90;
            grapefruitPrice = 1.60;
            kiwiPeice = 3.00;
            pineapplePrice = 5.60;
            grapesPrice = 4.20;
            switch (fruitName) {
                case "banana":
                    allPrice = bananaPrice * quantity;
                case "apple":
                    allPrice = applePrice * quantity;
                case "orange":
                    allPrice = orangePrice * quantity;
                case "grapefruit":
                    allPrice = grapesPrice * quantity;
                case "kiwi":
                    allPrice = kiwiPeice * quantity;
                case "pineapple":
                    allPrice = pineapplePrice * quantity;
                case "grapes":
                    allPrice = grapesPrice * quantity;
                    console.log(allPrice.toFixed(2));
                    break;
                default:
                    console.log("error");
                    break;
            }
            break;
        default:
            console.log("error");
            break;
    }
}
fruitShop(["grapefruit",
    "Saturday",
    "1.25"
])