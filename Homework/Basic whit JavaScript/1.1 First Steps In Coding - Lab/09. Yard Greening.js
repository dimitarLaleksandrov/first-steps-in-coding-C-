function yardGreening(input) {
    const costForEachKVM = 7.61;
    let metehrsForGreening = input[0];
    let allPrice = metehrsForGreening * costForEachKVM;
    let discount = allPrice * 0.18;
    let finalPrice = allPrice - discount;
    console.log(`The final price is: ${finalPrice} lv.`)
    console.log(`The discount is: ${discount} lv.`)
}