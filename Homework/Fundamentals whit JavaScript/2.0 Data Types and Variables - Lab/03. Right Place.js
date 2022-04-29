function rightPlace(string, symbol, mach) {
    let newString = "";
    for (let i = 0; i < string.length; i++) {
        if (string[i] === "_") {
            newString += symbol;
        } else {
            newString += string[i];
        }
    }
    if (newString === mach) {
        console.log(`Matched`);
    } else {
        console.log(`Not Matched`);
    }
}
rightPlace('Str_ng', 'I', 'Strong')
rightPlace('Str_ng', 'i', 'String')