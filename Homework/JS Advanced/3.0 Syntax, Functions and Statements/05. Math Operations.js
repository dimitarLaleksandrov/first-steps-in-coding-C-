function mathOperations(num1, num2, opereitor) {
    let result;
    switch (opereitor) {
        case `+`:
            result = num1 + num2;
            break;
        case `-`:
            result = num1 - num2;
            break;
        case `/`:
            result = num1 / num2;
            break;
        case `*`:
            result = num1 * num2;
            break;
        case `%`:
            result = num1 % num2;
            break;
        case `**`:
            result = num1 ** num2;
            break;
    }
    console.log(result);
}
mathOperations(3, 5.5, '**');