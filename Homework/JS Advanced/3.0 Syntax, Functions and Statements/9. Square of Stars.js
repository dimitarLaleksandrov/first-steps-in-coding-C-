function squareOfStars(input) {
    let n = Number(input);
    console.log("* ".repeat(n));
    for (let i = 1; i < n; i++) {
        console.log("* ".repeat(n));
    }
}
squareOfStars(4);