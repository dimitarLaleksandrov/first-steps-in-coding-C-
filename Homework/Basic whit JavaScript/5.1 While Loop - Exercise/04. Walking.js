function walking(input) {
    const stepsTOGoal = 10000;
    let command;
    index = 0;
    let steps = 0;
    let numPsteps;
    let stepsOverTheGoal = 0;
    while ((command = input[index]) !== "Going home") {
        index++;
        numPsteps = Number(command);
        steps += numPsteps;
        if (steps >= stepsTOGoal) {
            stepsOverTheGoal = steps - stepsTOGoal;
            console.log(`Goal reached! Good job!`);
            console.log(`${stepsOverTheGoal} steps over the goal!`);
            break;
        }
    }
    index++
    let lastSteps = Number(input[index]);
    steps += lastSteps;
    if (steps < stepsTOGoal) {
        let stepsNeedet = stepsTOGoal - steps;
        console.log(`${stepsNeedet} more steps to reach goal.`);
    } else if (steps >= stepsTOGoal) {
        let stepsOverTheGoal = steps - stepsTOGoal;
        console.log(`Goal reached! Good job!`);
        console.log(`${stepsOverTheGoal} steps over the goal!`);
    }
}