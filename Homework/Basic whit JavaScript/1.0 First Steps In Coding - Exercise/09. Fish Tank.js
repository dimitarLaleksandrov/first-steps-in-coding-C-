function fishTank(input) {
    let length = Number(input[0]);
    let width = Number(input[1]);
    let height = Number(input[2]);
    let percentage = Number(input[3]);
    let liters = (length * width * height) * 0.001;
    let occupiedSpace = percentage / 100;
    let litersNeedet = liters - (liters * occupiedSpace);
    console.log(litersNeedet);
}