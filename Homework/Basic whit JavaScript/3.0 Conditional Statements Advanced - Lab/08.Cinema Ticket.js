function cinemaTiket(input) {
    let day = input[0];
    let tiketPrice = 0;
    switch (day) {
        case "Monday":
        case "Friday":
        case "Tuesday":
            tiketPrice = 12;
            break;
        case "Wednesday":
        case "Thursday":
            tiketPrice = 14;
            break;
        case "Saturday":
            tiketPrice = 16;
        case "Sunday":
            tiketPrice = 16;
            break;
        default:
            break;
    }
    console.log(tiketPrice);
}