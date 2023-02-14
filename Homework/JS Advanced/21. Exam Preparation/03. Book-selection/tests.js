let bookSelection = require('./solution');
let { assert } = require('chai');
describe("Tests for bookSelection", function() {
    describe("Test isGenreSuitable", () => {
        it("genreTitle", () => {
            let genre = "Thriller";
            let age = 12;
            let expected = `Books with ${genre} genre are not suitable for kids at ${age} age`;
            assert.equal(bookSelection.isGenreSuitable(genre, age), expected);
        });
    });
    describe("Test isGenreSuitable", () => {
        it("genreAndAge", () => {
            let genre = "Horror";
            let age = 11;
            let expected = `Books with ${genre} genre are not suitable for kids at ${age} age`;
            assert.equal(bookSelection.isGenreSuitable(genre, age), expected);
        });
    });
    describe("Test isGenreSuitable", () => {
        it("genreAndAge", () => {
            let genre = "";
            let age = 18;
            let expected = `Those books are suitable`;
            assert.equal(bookSelection.isGenreSuitable(genre, age), expected);
        });
    });
    describe("Test isItAffordable", () => {
        it("NaN", () => {
            let price = "6";
            let budget = '18';
            let expected = `Invalid input`;
            assert.throw(function() { bookSelection.isItAffordable(price, budget) }, expected);
        });
    });
    describe("Test isItAffordable", () => {
        it("NaN", () => {
            let price = "6";
            let budget = 18;
            let expected = `Invalid input`;
            assert.throw(function() { bookSelection.isItAffordable(price, budget) }, expected);
        });
    });
    describe("Test isItAffordable", () => {
        it("not enough money", () => {
            let price = 10;
            let budget = 1;
            let expected = "You don't have enough money";
            assert.equal(bookSelection.isItAffordable(price, budget), expected);
        });
    });
    describe("Test isItAffordable", () => {
        it("not enough money", () => {
            let price = 10;
            let budget = 9;
            let expected = "You don't have enough money";
            assert.equal(bookSelection.isItAffordable(price, budget), expected);
        });
    });
    describe("Test isItAffordable", () => {
        it("budget", () => {
            let price = 10;
            let budget = 50;
            let result = budget - price;
            let expected = `Book bought. You have ${result}$ left`;
            assert.equal(bookSelection.isItAffordable(price, budget), expected);
        });
    });
    describe("Test isItAffordable", () => {
        it("budget", () => {
            let price = 10;
            let budget = 10;
            let result = budget - price;
            let expected = `Book bought. You have ${result}$ left`;
            assert.equal(bookSelection.isItAffordable(price, budget), expected);
        });
    });
    describe("Test suitableTitles", () => {
        it("arrIsArr", () => {
            let array = 10;
            let wantedGenre = "pesho";
            let expected = "Invalid input";
            assert.throw(() => bookSelection.suitableTitles(array, wantedGenre), expected);
        });
    });
    describe("Test suitableTitles", () => {
        it("arrIsArr", () => {
            let array = 10;
            let wantedGenre = 1;
            let expected = "Invalid input";
            assert.throw(() => bookSelection.suitableTitles(array, wantedGenre), expected);
        });
    });
    describe("Test suitableTitles", () => {
        it("arrIsArr", () => {
            let array = [];
            let wantedGenre = 1;
            let expected = "Invalid input";
            assert.throw(() => bookSelection.suitableTitles(array, wantedGenre), expected);
        });
    });
    describe("Test suitableTitles", () => {
        it("isArrFull", () => {

            let input = [
                { title: "Te Da Vinci Code", genre: "Thriller" },
                { title: "The D Vinci Code", genre: "Thrler" },
                { title: "The Da Vici Coe", genre: "Th" },
                { title: "Th Da Vici Code", genre: "Tler" }
            ];
            let resultArr = [
                "Te Da Vinci Code"
            ];
            assert.equal(bookSelection.suitableTitles(input, "Thriller").join(" "), resultArr.join(" "));
        });
    });
});