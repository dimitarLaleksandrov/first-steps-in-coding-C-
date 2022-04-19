function cake(input) {
    let width = Number(input[0]);
    let length = Number(input[1]);
    let allCace = width * length;
    let index = 2;
    let needetPieces = 0;
    let command;
    while ((command = input[index]) !== "STOP") {
        let pices = Number(command);
        index++;
        if (allCace < pices) {
            needetPieces = pices - allCace;
            console.log(`No more cake left! You need ${needetPieces} pieces more.`);
            break;
        }
        allCace -= pices;
    }
    if (allCace >= 0 && command === "STOP") {
        let piecesLeft = allCace;
        console.log(`${piecesLeft} pieces are left.`);
    }
}