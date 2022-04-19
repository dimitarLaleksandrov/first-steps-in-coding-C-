function tipePlus(input) {
    const addMIn = 15;
    let howers = Number(input[0]);
    let minets = Number(input[1]);
    let newMin = minets + addMIn;
    if (newMin > 59) {
        howers += 1;
        newMin = newMin - 60;
        if (howers > 23) {
            howers = 0;
        }
    }
    if (newMin < 10) {
        console.log(`${howers}:0${newMin}`);
    } else {
        console.log(`${howers}:${newMin}`);
    }
}