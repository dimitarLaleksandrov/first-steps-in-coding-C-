function echoTypes(input) {
    let type = typeof input;
    if (type == 'string') {
        console.log(`string`);
        console.log(input);
    } else if (type == 'number') {
        console.log(`number`);
        console.log(input);
    } else {
        console.log(`object`);
        console.log(`Parameter is not suitable for printing`);
    }
}
echoTypes('Hello, JavaScript!')
echoTypes(18)
echoTypes(-1, "hey")