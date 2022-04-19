function fruitOrVegi(input) {
    let tipe = input[0];
    let tipeIs;
    switch (tipe) {
        case "banana":
        case "apple":
        case "kiwi":
        case "cherry":
        case "lemon":
        case "grapes":
            tipeIs = "fruit";
            break;
        case "tomato":
        case "cucumber":
        case "pepper":
        case "carrot":
            tipeIs = "vegetable";
            break;
        default:
            tipeIs = "unknown";
            break;
    }
    console.log(tipeIs);
}