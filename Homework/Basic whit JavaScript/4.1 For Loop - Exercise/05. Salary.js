function salary(input) {
    const facebook = 150;
    const instargram = 100;
    const reddit = 50;
    let numOfTabs = Number(input[0]);
    let salary = Number(input[1]);
    let money = salary;
    for (let i = 1; i <= numOfTabs + 1; i++) {
        let website = input[i];
        if (website === "Facebook") {
            money -= facebook;
        } else if (website === "Instagram") {
            money -= instargram;
        } else if (website === "Reddit") {
            money -= reddit;
        }
        if (money <= 0) {
            console.log(`You have lost your salary.`);
            break;
        }
    }
    if (money > 0) {
        console.log(`${Math.abs(money)}`)
    }
}