function radialConverter(input) {
    const degreesFunction = 180 / Math.PI;
    let radial = input[0];
    let degrees = radial * degreesFunction;
    console.log(degrees);
}