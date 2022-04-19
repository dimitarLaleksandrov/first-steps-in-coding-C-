function oscars(input) {
    let actiorName = input[0];
    let academyPoint = Number(input[1]);
    let evaluatorsNum = Number(input[2]);
    let index = 3;
    for (let i = 0; i < evaluatorsNum; i++) {
        let judgeName = input[index];
        index++;
        let jugePoints = Number(input[index]);
        index++;
        let resolt = judgeName.length * jugePoints / 2;
        academyPoint += resolt;
        if (academyPoint > 1250.5) {
            console.log(`Congratulations, ${actiorName} got a nominee for leading role with ${academyPoint.toFixed(1)}!`);
            break;
        }
    }
    if (academyPoint <= 1250.5) {
        let pointneed = 1250.5 - academyPoint;
        console.log(`Sorry, ${actiorName} you need ${pointneed.toFixed(1)} more!`);
    }
}