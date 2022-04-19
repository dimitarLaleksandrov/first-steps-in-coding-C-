function examPrepear(input) {
    let unsatisfactorGrades = Number(input[0]);
    let index = 1;
    let nameOfTheTask;
    let numberOfProblems = 0;
    let raiting = 0;
    let allRatings = 0;
    let avarigRating = 0;
    let lastProblem;
    let problems = 0;
    while ((nameOfTheTask = input[index]) !== "Enough") {
        lastProblem = nameOfTheTask;
        problems++;
        index++;
        raiting = Number(input[index]);
        allRatings += raiting;
        if (raiting <= 4) {
            numberOfProblems++;
        }
        if (numberOfProblems === unsatisfactorGrades) {
            console.log(`You need a break, ${numberOfProblems} poor grades.`);
            break;
        }
        index++;
    }
    if (numberOfProblems !== unsatisfactorGrades) {
        avarigRating = allRatings / problems;
        console.log(`Average score: ${avarigRating.toFixed(2)}`);
        console.log(`Number of problems: ${problems}`);
        console.log(`Last problem: ${lastProblem}`);
    }
}