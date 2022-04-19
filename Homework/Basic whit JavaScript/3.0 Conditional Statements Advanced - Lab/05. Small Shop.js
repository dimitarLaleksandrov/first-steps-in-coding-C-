function smallShop(input) {
    let produkt = input[0];
    let city = input[1];
    let quantity = Number(input[2]);
    let coffePrice = 0;
    let waterPrice = 0;
    let beerPrice = 0;
    let sweetsPrice = 0;
    let peanutsPrice = 0;
    let allPrice = 0;
    switch (city) {
        case "Sofia":
            switch (produkt) {
                case "coffee":
                    coffePrice = 0.50;
                    allPrice = coffePrice * quantity;
                    break;
                case "water":
                    waterPrice = 0.80;
                    allPrice = waterPrice * quantity;
                    break;
                case "beer":
                    beerPrice = 1.20;
                    allPrice = beerPrice * quantity;
                    break;
                case "sweets":
                    sweetsPrice = 1.45;
                    allPrice = sweetsPrice * quantity;
                    break;
                case "peanuts":
                    peanutsPrice = 1.60;
                    allPrice = peanutsPrice * quantity;
                    break;
                default:
                    break;
            }
            break;
        case "Plovdiv":
            switch (produkt) {
                case "coffee":
                    coffePrice = 0.40;
                    allPrice = coffePrice * quantity;
                    break;
                case "water":
                    waterPrice = 0.70;
                    allPrice = waterPrice * quantity;
                    break;
                case "beer":
                    beerPrice = 1.15;
                    allPrice = beerPrice * quantity;
                    break;
                case "sweets":
                    sweetsPrice = 1.30;
                    allPrice = sweetsPrice * quantity;
                    break;
                case "peanuts":
                    peanutsPrice = 1.50;
                    allPrice = peanutsPrice * quantity;
                    break;
                default:
                    break;
            }
            break;
        case "Varna":
            switch (produkt) {
                case "coffee":
                    coffePrice = 0.45;
                    allPrice = coffePrice * quantity;
                    break;
                case "water":
                    waterPrice = 0.70;
                    allPrice = waterPrice * quantity;
                    break;
                case "beer":
                    beerPrice = 1.10;
                    allPrice = beerPrice * quantity;
                    break;
                case "sweets":
                    sweetsPrice = 1.35;
                    allPrice = sweetsPrice * quantity;
                    break;
                case "peanuts":
                    peanutsPrice = 1.55;
                    allPrice = peanutsPrice * quantity;
                    break;
                default:
                    break;
            }
            break;
        default:
            break;
    }
    console.log(allPrice);
}