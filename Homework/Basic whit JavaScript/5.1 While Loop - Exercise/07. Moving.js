function moving(input) {
    let width = Number(input[0]);
    let length = Number(input[1]);
    let height = Number(input[2]);
    let allCubesMeters = width * length * height;
    let index = 3;
    let command = String;
    while ((command = input[index++]) !== "Done") {
        let numOfBoxes = Number(command);
        if (allCubesMeters < numOfBoxes) {
            let boxesLeft = numOfBoxes - allCubesMeters;
            console.log(`No more free space! You need ${boxesLeft} Cubic meters more.`);
            break;
        }
        allCubesMeters -= numOfBoxes
    }
    if (allCubesMeters >= 0 && command === "Done") {
        let freeSpace = allCubesMeters;
        console.log(`${freeSpace} Cubic meters left.`);
        console.log(`${freeSpace} Cubic meters left.`);
    }
}