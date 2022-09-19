function fruit(fruit, weight, price) {
    var kilos = weight / 1000;
    var allPrice = kilos * price;
    console.log(`I need $${allPrice.toFixed(2)} to buy ${kilos.toFixed(2)} kilograms ${fruit}.`);

}
fruit('orange', 2500, 1.80);