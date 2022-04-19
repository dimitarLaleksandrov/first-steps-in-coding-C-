function workingHours(input) {
    let hower = Number(input[0]);
    let day = input[1];
    switch (day) {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
            if (hower >= 10 && hower <= 18) {
                console.log("open");
            } else {
                console.log("closed");
            }
            break;
        case "Sunday":
            console.log("closed");
            break;
        default:
            break;
    }
}