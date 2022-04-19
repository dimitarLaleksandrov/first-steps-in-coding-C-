function oldBooks(input) {
    let boockToFind = input[0];
    let index = 1;
    let books;
    let boockCounter = 0;
    while ((books = input[index]) !== "No More Books") {
        if (books === boockToFind) {
            console.log(`You checked ${boockCounter} books and found it.`);
            break;
        }
        boockCounter++;
        index++;
    }
    if (boockToFind !== books) {
        console.log(`The book you search is not here!`);
        console.log(`You checked ${boockCounter} books.`);
    }
}