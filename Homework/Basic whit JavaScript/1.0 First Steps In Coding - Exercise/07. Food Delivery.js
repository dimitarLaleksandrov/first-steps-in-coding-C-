function foodDelivery(input) {
    const chiken = 10.35;
    const fish = 12.40;
    const vegMeal = 8.15;
    const delivery = 2.50;
    let chikeansMeals = Number(input[0]);
    let fishMeals = Number(input[1]);
    let vegensMeal = Number(input[2]);
    let mealSum = (chikeansMeals * chiken) + (fishMeals * fish) + (vegensMeal * vegMeal)
    let desertPrice = mealSum * 0.20;
    let allSum = mealSum + desertPrice + delivery;
    console.log(allSum);
}