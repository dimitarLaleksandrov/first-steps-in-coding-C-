function timeToWalk(steps, footprintLength, speed) {
    let distance = steps * footprintLength;
    let speedInSeconds = speed / 3.6;
    let time = distance / speedInSeconds;
    let studentRes = Math.floor(distance / 500);
    let timeInMin = Math.floor(time / 60);
    let timeInsec = Number(time - (timeInMin * 60)).toFixed(0);
    let timeInH = Math.floor(time / 3600);
    timeInMin += studentRes;
    timeInH += Math.floor(timeInMin / 60);
    timeInMin = timeInMin % 60;
    let formatH = timeInH < 10 ? `0${timeInH}` : `${timeInH}`;
    let formatMin = timeInMin < 10 ? `0${timeInMin}` : `${timeInMin}`;
    let formatSec = timeInsec < 10 ? `0${timeInsec}` : `${timeInsec}`;
    console.log(`${formatH}:${formatMin}:${formatSec}`);
}
timeToWalk(4000, 0.60, 5);