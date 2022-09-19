function evenPositionElement(input) {
    let evenPosishanNums = [];
    for (let i = 0; i < input.length; i++) {
        if (i % 2 == 0) {
            evenPosishanNums.push(input[i]);
        }
    }
    console.log(evenPosishanNums.join(" "));
}
evenPositionElement(['20', '30', '40', '50', '60']);