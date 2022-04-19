function areaOfFigures(input) {
    let tipe = input[0];
    if (tipe == "square") {
        let square = Number(input[1]);
        let resolt = square * square;
        console.log(resolt.toFixed(3));
    } else if (tipe == "rectangle") {
        let firstSize = Number(input[1]);
        let secondSize = Number(input[2]);
        let resolt = firstSize * secondSize;
        console.log(resolt.toFixed(3));
    } else if (tipe == "circle") {
        let radius = Number(input[1]);
        let resolt = Math.PI * radius * radius;
        console.log(resolt.toFixed(3));
    } else if (tipe == "triangle") {
        let lenghtOfSide = Number(input[1]);
        let lenghtOfheight = Number(input[2]);
        let resolt = (lenghtOfSide / 2) * lenghtOfheight;
        console.log(resolt.toFixed(3));
    }
}