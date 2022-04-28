function numberPyramid(input) {
    let num = Number(input[0]);
    let piramid = "";
    let counter = 1;
    for (i = 1; i <= num; i++) {
        for (j = 1; j <= i; j++) {
            piramid += counter + " ";
            counter++;
            if (counter > num) {
                break;
            }
        }
        console.log(piramid);
        piramid = "";
        if (counter > num) {
            break;
        }
    }
}