function previousDay(year, month, day) {
    let curentDate = new Date(year, month - 1, day);
    curentDate.setDate(curentDate.getDate() - 1);
    console.log(`${curentDate.getFullYear()}-${curentDate.getMonth() + 1}-${curentDate.getDate()}`);
}
previousDay(2016, 10, 1);