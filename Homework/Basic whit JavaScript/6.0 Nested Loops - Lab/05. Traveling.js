function traveling(input) {
    let coomand;
    let index = 0;
    while ((coomand = input[index] !== "End")) {
        let contry = input[index];
        index++;
        let sumToGoal = input[index];
        index++;
        let num = Number(input[index]);
        for (let i = num; i < sumToGoal; i += num) {
            index++;
            num = Number(input[index]);
        }
        console.log(`Going to ${contry}!`);
        index++;
    }
}