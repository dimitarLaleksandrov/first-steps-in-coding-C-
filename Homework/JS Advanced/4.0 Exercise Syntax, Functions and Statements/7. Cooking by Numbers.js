function cookingByNumbers(inputNum, opr1, opr2, opr3, opr4, opr5) {
    inputNum = manipulaitFunc(inputNum, opr1);
    inputNum = manipulaitFunc(inputNum, opr2);
    inputNum = manipulaitFunc(inputNum, opr3);
    inputNum = manipulaitFunc(inputNum, opr4);
    inputNum = manipulaitFunc(inputNum, opr5);

}

function manipulaitFunc(num, opr) {
    let number = Number(num);
    switch (opr) {
        case 'chop':
            number /= 2;
            break;
        case 'dice':
            number = Math.sqrt(number);
            break;
        case 'spice':
            number += 1;
            break;
        case 'bake':
            number *= 3;
            break;
        case 'fillet':
            number *= 0.80;
            break;
        default:
            break;
    }
    console.log(number);
    return number;
}
cookingByNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop');