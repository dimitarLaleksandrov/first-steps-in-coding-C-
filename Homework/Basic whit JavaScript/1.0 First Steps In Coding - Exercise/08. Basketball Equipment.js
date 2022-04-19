function basketball(input) {
    let yearTax = Number(input[0]);
    let sneakers = yearTax - (yearTax * 0.40);
    let outfit = sneakers - (sneakers * 0.20);
    let basketBalls = outfit / 4;
    let bastketAccessories = basketBalls / 5;
    let allSum = yearTax + sneakers + outfit + basketBalls + bastketAccessories;
    console.log(allSum);
}