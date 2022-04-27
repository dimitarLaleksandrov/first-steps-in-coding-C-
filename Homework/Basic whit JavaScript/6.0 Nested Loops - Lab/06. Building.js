function building(input) {
    let flors = Number(input[0]);
    let rooms = Number(input[1]);
    let counter = 0;
    for (let i = flors; i >= 1; i--) {
        counter++;
        let string = "";
        for (let j = 0; j < rooms; j++) {
            if (counter === 1) {
                string += "L" + i + j + " ";
            } else if (i % 2 === 0) {
                string += "O" + i + j + " ";
            } else {
                string += "A" + i + j + " ";
            }
        }
        console.log(string);
    }
}