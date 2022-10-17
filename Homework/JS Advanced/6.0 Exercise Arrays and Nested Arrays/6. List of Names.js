function listOIfNames(input) {
    let output = input.sort((a, b) => a.localeCompare(b));
    for (let i = 0; i < output.length; i++) {
        console.log(`${i + 1}.${output[i]}`);
    }
}
listOIfNames(["John", "Bob", "Christina", "Ema"]);