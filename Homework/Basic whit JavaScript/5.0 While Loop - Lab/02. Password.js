function password(input) {
    let name = input[0];
    let password = input[1];
    let index = 2;
    let passchek;
    while ((passchek = input[index]) !== password) {
        index += 1;
    }
    console.log(`Welcome ${name}!`);
}