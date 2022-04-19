function worldrecord(input) {
    let record = Number(input[0]);
    let distance = Number(input[1]);
    let time = Number(input[2]);
    let timeNeed = (distance * time);
    let addTime = 0;
    if (distance >= 15) {
        addTime = Math.floor(distance / 15) * 12.5;
    }
    let allTime = (timeNeed + addTime);
    if (allTime >= record) {
        let secondsSlower = (allTime - record);
        console.log(`No, he failed! He was ${secondsSlower.toFixed(2)} seconds slower.`)
    } else {
        console.log(`Yes, he succeeded! The new world record is ${allTime.toFixed(2)} seconds.`)
    }
}