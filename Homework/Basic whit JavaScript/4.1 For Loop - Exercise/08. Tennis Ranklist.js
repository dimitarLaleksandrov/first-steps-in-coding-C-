function tennisRanking(input) {
    const w = 2000;
    const f = 1200;
    const sf = 720;
    let numOfTurnirs = Number(input[0]);
    let startPoint = Number(input[1]);
    let index = 2;
    let winTurnaments = 0;
    let pointsErnet = 0;
    for (let i = 0; i < numOfTurnirs; i++) {
        let turnirTipe = input[index];
        index++;
        if (turnirTipe === "W") {
            startPoint += w;
            winTurnaments += 1;
            pointsErnet += w;
        } else if (turnirTipe === "F") {
            startPoint += f;
            pointsErnet += f;
        } else if (turnirTipe === "SF") {
            startPoint += sf;
            pointsErnet += sf;
        }
    }
    let averigPoints = Math.floor(pointsErnet / numOfTurnirs);
    let winTurnamentInProcent = (winTurnaments / numOfTurnirs) * 100;
    let finalPoints = startPoint;
    console.log(`Final points: ${finalPoints}`);
    console.log(`Average points: ${averigPoints}`);
    console.log(`${winTurnamentInProcent.toFixed(2)}%`);
}