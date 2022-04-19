function passGuess(input) {
    const password = "s3cr3t!P@ssw0rd";
    let passGess = input[0];
    if (passGess == password) {
        console.log("Welcome");
    } else {
        console.log("Wrong password!");
    }
}