function cinema(input) {
    const premierePrice = 12.00;
    const normalPrice = 7.50;
    const discountPrice = 5.00;
    let cinemaMode = input[0];
    let cinemaRows = Number(input[1]);
    let cinemaColumns = Number(input[2]);
    let finalPrice = 0;
    if (cinemaMode === "Premiere") {
        finalPrice = cinemaColumns * cinemaRows * premierePrice;
    } else if (cinemaMode === "Normal") {
        finalPrice = cinemaColumns * cinemaRows * normalPrice;
    } else if (cinemaMode === "Discount") {
        finalPrice = cinemaColumns * cinemaRows * discountPrice;
    }
    console.log(finalPrice.toFixed(2));
}