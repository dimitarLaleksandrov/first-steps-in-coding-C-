function sumSeconds(input) {
    let firstTime = Number(input[0]);
    let secondTime = Number(input[1]);
    let therdTime = Number(input[2]);
    let totalTime = firstTime + secondTime + therdTime;
    let min = Math.floor(totalTime / 60);
    let sec = totalTime % 60;
    if (sec < 10) {
        console.log(`${min}:0${sec}`);
    } else {
        console.log(`${min}:${sec}`);
    }
}