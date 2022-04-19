function personalTitle(input) {
    let age = Number(input[0]);
    let gender = input[1];
    switch (gender) {
        case "f":
            if (age >= 16) {
                console.log("Ms.");
            } else if (age < 16 && age > 0) {
                console.log("Miss");
            }
            break;
        case "m":
            if (age >= 16) {
                console.log("Mr.");
            } else if (age < 16 && age > 0) {
                console.log("Master");
            }
            break;
    }
}