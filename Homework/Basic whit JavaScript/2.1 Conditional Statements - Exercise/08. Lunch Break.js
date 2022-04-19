function lunchBreak(input) {
    let nameOfTheSeres = input[0];
    let searisTime = Number(input[1]);
    let breakTime = Number(input[2]);
    let luckTime = breakTime / 8;
    let restTime = breakTime / 4;
    let lunckBreak = luckTime + restTime;
    let timeLeft = breakTime - lunckBreak;
    let time = 0;
    if (timeLeft >= searisTime) {
        time = Math.ceil(timeLeft - searisTime);
        console.log(`You have enough time to watch ${nameOfTheSeres} and left with ${time} minutes free time.`)
    } else {
        time = Math.ceil(searisTime - timeLeft);
        console.log(`You don't have enough time to watch ${nameOfTheSeres}, you need ${time} more minutes.`)
    }
}