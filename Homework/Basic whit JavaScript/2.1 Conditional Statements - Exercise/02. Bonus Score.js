function bonusScore(input) {
    let num = Number(input[0]);
    let point = Number();
    if (num <= 100) {
        point += 5;
        if (num % 2 == 0) {
            point += 1;
        } else if (num % 5 == 0) {
            point += 2;
        }
    } else if (num > 100 && num <= 1000) {
        point += num * 0.20;
        if (num % 2 == 0) {
            point += 1;
        } else if (num % 5 == 0) {
            point += 2;
        }
    } else if (num > 1000) {
        point += num * 0.10;
        if (num % 2 == 0) {
            point += 1;
        } else if (num % 5 == 0) {
            point += 2;
        }
    }
    let allPoints = num + point;
    console.log(point);
    console.log(allPoints);
}