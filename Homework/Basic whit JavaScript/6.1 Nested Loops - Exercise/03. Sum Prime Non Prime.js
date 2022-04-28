function sumPrime(input) {
    let num = "";
    let index = 0;
    let primeNumSum = 0;
    let nonprimeNumSum = 0;
    while ((num = input[index]) !== "stop") {
        let number = Number(input[index]);
        if (number < 0) {
            console.log(`Number is negative.`);
            index++;
            continue;
        }
        if (number > 2) {
            if (number > 3) {
                if (number / 1 === number && number / number === 1 && number % 3 === 0 || number % 2 === 0) {
                    nonprimeNumSum += number;
                } else {
                    primeNumSum += number;
                }
            } else {
                primeNumSum += number;
            }
        } else {
            primeNumSum += number;
        }
        index++
    }
    console.log(`Sum of all prime numbers is: ${primeNumSum}`);
    console.log(`Sum of all non prime numbers is: ${nonprimeNumSum}`);
}