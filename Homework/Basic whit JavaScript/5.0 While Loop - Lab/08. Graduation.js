function graduation(input) {
    const clasToGoal = 12;
    let nameOfTheStudent = input[0];
    let index = 1;
    let gradeAt = 1;
    let allGrades = 0;
    let toBeExcluded;
    while (gradeAt <= clasToGoal) {
        let rating = Number(input[index]);
        if (rating >= 4.00) {
            gradeAt++;
            allGrades += rating;
            toBeExcluded = 0;
        } else {
            toBeExcluded++;
            if (toBeExcluded === 2) {
                console.log(`${nameOfTheStudent} has been excluded at ${gradeAt} grade`)
                break;
            }
        }
        index++
    }
    let avarigGrades = allGrades / 12;
    if (toBeExcluded < 2) {
        console.log(`${nameOfTheStudent} graduated. Average grade: ${avarigGrades.toFixed(2)}`);
    }
}