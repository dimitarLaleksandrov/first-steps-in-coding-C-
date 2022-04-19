function projects(input) {
    const howersNeedet = 3;
    let name = input[0];
    let numberOfProjects = input[1];
    let howersToComplete = numberOfProjects * howersNeedet;
    console.log(`The architect ${name} will need ${howersToComplete} hours to complete ${numberOfProjects} project/s.`)
}