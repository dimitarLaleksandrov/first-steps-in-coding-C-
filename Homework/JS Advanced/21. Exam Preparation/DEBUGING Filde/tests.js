let chooseYourCar = require('./solution');
let { assert } = require('chai');

describe("Tests for chooseYourCar", function() {
    describe("Test choosingType", () => {
        it("Test the years shud trhow error", () => {
            let year = 1888;
            let color = "red";
            let type = "Sedan"
            let expected = `Invalid Year!`;
            assert.throw(function() { chooseYourCar.choosingType(type, color, year) }, expected);
        });
        it("Test the years shud trhow error", () => {
            let year = 2023;
            let color = "red";
            let type = "Sedan"
            let expected = `Invalid Year!`;
            assert.throw(function() { chooseYourCar.choosingType(type, color, year) }, expected);
        });
        it("Test the type", () => {
            let year = 2010;
            let color = "red";
            let type = "Sedan"
            let expected = `This ${color} ${type} meets the requirements, that you have.`;
            assert.equal(chooseYourCar.choosingType(type, color, year), expected);
        });
        it("Test the type", () => {
            let year = 2009;
            let color = "red";
            let type = "Sedan"
            let expected = `This ${type} is too old for you, especially with that ${color} color.`;
            assert.equal(chooseYourCar.choosingType(type, color, year), expected);
        });
        it("Test the type", () => {
            let year = 2009;
            let color = "red";
            let type = "mara"
            let expected = `This type of car is not what you are looking for.`;
            assert.throw(function() { chooseYourCar.choosingType(type, color, year) }, expected);
        });
    });
    describe("Test brandName", () => {
        it("Test the input is not arr", () => {
            let brands = '';
            let brandIndex = 4;
            let expected = `Invalid Information!`;
            assert.throw(function() { chooseYourCar.brandName(brands, brandIndex) }, expected);
        });
        it("Test the input is not arr", () => {
            let brands = [];
            let brandIndex = `2`;
            let expected = `Invalid Information!`;
            assert.throw(function() { chooseYourCar.brandName(brands, brandIndex) }, expected);
        });
        it("Test the input is not arr", () => {
            let brands = [];
            let brandIndex = -1;
            let expected = `Invalid Information!`;
            assert.throw(function() { chooseYourCar.brandName(brands, brandIndex) }, expected);
        });
        it("Test the input is not arr", () => {
            let brands = [];
            let brandIndex = 1;
            let expected = `Invalid Information!`;
            assert.throw(function() { chooseYourCar.brandName(brands, brandIndex) }, expected);
        });
        it("Test the input is not arr", () => {
            let brands = ["Pecho", "Ivan", "Dima", "MItko"];
            let brandIndex = 3;
            let expected = ["Pecho", "Ivan", "Dima"].join(", ");
            assert.equal(chooseYourCar.brandName(brands, brandIndex), expected);
        });
    });
    describe("Test carFuelConsumption", () => {
        it("Test the input is NaN", () => {
            let distanceInKilometers = '1';
            let consumptedFuelInLiters = 1;
            let expected = `Invalid Information!`;
            assert.throw(function() { chooseYourCar.carFuelConsumption(distanceInKilometers, consumptedFuelInLiters) }, expected);
        });
        it("Test the input is NaN", () => {
            let distanceInKilometers = 1;
            let consumptedFuelInLiters = `1`;
            let expected = `Invalid Information!`;
            assert.throw(function() { chooseYourCar.carFuelConsumption(distanceInKilometers, consumptedFuelInLiters) }, expected);
        });
        it("Test the input is negatin ", () => {
            let distanceInKilometers = -1;
            let consumptedFuelInLiters = 4;
            let expected = `Invalid Information!`;
            assert.throw(function() { chooseYourCar.carFuelConsumption(distanceInKilometers, consumptedFuelInLiters) }, expected);
        });
        it("Test the input is negatin ", () => {
            let distanceInKilometers = 3;
            let consumptedFuelInLiters = -4;
            let expected = `Invalid Information!`;
            assert.throw(function() { chooseYourCar.carFuelConsumption(distanceInKilometers, consumptedFuelInLiters) }, expected);
        });
        it("Test litersPerHundredKm", () => {
            let distanceInKilometers = 50;
            let consumptedFuelInLiters = 3;
            let litersPerHundredKm = ((consumptedFuelInLiters / distanceInKilometers) * 100).toFixed(2);
            let expected = `The car is efficient enough, it burns ${litersPerHundredKm} liters/100 km.`;
            assert.equal(chooseYourCar.carFuelConsumption(distanceInKilometers, consumptedFuelInLiters), expected);
        });
        it("Test litersPerHundredKm is to mach ", () => {
            let distanceInKilometers = 5;
            let consumptedFuelInLiters = 3;
            let litersPerHundredKm = ((consumptedFuelInLiters / distanceInKilometers) * 100).toFixed(2);
            let expected = `The car burns too much fuel - ${litersPerHundredKm} liters!`;
            assert.equal(chooseYourCar.carFuelConsumption(distanceInKilometers, consumptedFuelInLiters), expected);
        });
    });
});





// let companyAdministration = require('./solution');
// let { assert } = require('chai');
// describe("Tests for companyAdministration", function() {
//     describe("Test hiringEmployee", () => {
//         it("Test if the person is successfully hired ", () => {
//             let name = "Thriller";
//             let position = "Programmer";
//             let yearsExperience = 15;
//             let expected = `${name} was successfully hired for the position ${position}.`;
//             assert.equal(companyAdministration.hiringEmployee(name, position, yearsExperience), expected);
//         });
//     });
//     describe("Test hiringEmployee", () => {
//         it("Test if the person is successfully hired", () => {
//             let name = "Thriller";
//             let position = "Programmer";
//             let yearsExperience = 3;
//             let expected = `${name} was successfully hired for the position ${position}.`;
//             assert.equal(companyAdministration.hiringEmployee(name, position, yearsExperience), expected);
//         });
//     });
//     describe("Test hiringEmployee", () => {
//         it("Test approved for this position", () => {
//             let name = "Thriller";
//             let position = "Programmer";
//             let yearsExperience = 2;
//             let expected = `${name} is not approved for this position.`;
//             assert.equal(companyAdministration.hiringEmployee(name, position, yearsExperience), expected);
//         });
//     });
//     describe("Test hiringEmployee", () => {
//         it("Test not looking for workers for this position", () => {
//             let name = "Thriller";
//             let position = "Juniar";
//             let yearsExperience = 15;
//             let expected = `We are not looking for workers for this position.`;
//             assert.throw(function() { companyAdministration.hiringEmployee(name, position, yearsExperience) }, expected);
//         });
//     });
//     describe("Test calculateSalary", () => {
//         it("Test hours NaN", () => {
//             let hours = "3";
//             let payPerHour = 15;
//             let totalAmount = payPerHour * hours;
//             let expected = "Invalid hours";
//             assert.throw(function() { companyAdministration.calculateSalary(hours) }, expected);
//         });
//     });
//     describe("Test calculateSalary", () => {
//         it("Test totalAmount", () => {
//             let hours = 161;
//             let payPerHour = 15;
//             let totalAmount = payPerHour * hours;
//             let expected = totalAmount + 1000;
//             assert.equal(companyAdministration.calculateSalary(hours), expected);
//         });
//     });
//     describe("Test  firedEmployee", () => {
//         it("Test Invalid inpu", () => {
//             let result = [];
//             let employees = "";
//             let index = 4;
//             let expected = "Invalid input";
//             assert.throw(function() { companyAdministration.firedEmployee(employees, index) }, expected);
//         });
//     });
//     describe("Test  firedEmployee", () => {
//         it("Test Invalid inpu", () => {
//             let result = [];
//             let employees = ["Pecho", "Ivan", "Dima", "MItko"];
//             let index = '4';
//             let expected = "Invalid input";
//             assert.throw(function() { companyAdministration.firedEmployee(employees, index) }, expected);
//         });
//     });
//     describe("Test  firedEmployee", () => {
//         it("Test Invalid inpu", () => {
//             let result = [];
//             let employees = ["Pecho", "Ivan", "Dima", "MItko"];
//             let index = -1;
//             let expected = "Invalid input";
//             assert.throw(function() { companyAdministration.firedEmployee(employees, index) }, expected);
//         });
//     });
//     describe("Test  firedEmployee", () => {
//         it("Test Invalid inpu", () => {
//             let result = [];
//             let employees = ["Pecho", "Ivan", "Dima", "MItko"];
//             let index = 4;
//             let expected = "Invalid input";
//             assert.throw(function() { companyAdministration.firedEmployee(employees, index) }, expected);
//         });
//     });
//     describe("Test  firedEmployee", () => {
//         it("Test Invalid inpu", () => {
//             let result = [];
//             let employees = ["Pecho", "Ivan", "Dima", "MItko"];
//             let index = 3;
//             let expected = ["Pecho", "Ivan", "Dima"].join(", ");
//             assert.equal(companyAdministration.firedEmployee(employees, index), expected);
//         });
//     });
// });
// describe("Test isGenreSuitable", () => {
//     it("genreAndAge", () => {
//         let genre = "Horror";
//         let age = 11;
//         let expected = `Books with ${genre} genre are not suitable for kids at ${age} age`;
//         assert.equal(bookSelection.isGenreSuitable(genre, age), expected);
//     });
// });
// describe("Test isGenreSuitable", () => {
//     it("genreAndAge", () => {
//         let genre = "";
//         let age = 18;
//         let expected = `Those books are suitable`;
//         assert.equal(bookSelection.isGenreSuitable(genre, age), expected);
//     });
// });
// describe("Test isItAffordable", () => {
//     it("NaN", () => {
//         let price = "6";
//         let budget = '18';
//         let expected = `Invalid input`;
//         assert.throw(function() { bookSelection.isItAffordable(price, budget) }, expected);
//     });
// });
// describe("Test isItAffordable", () => {
//     it("NaN", () => {
//         let price = "6";
//         let budget = 18;
//         let expected = `Invalid input`;
//         assert.throw(function() { bookSelection.isItAffordable(price, budget) }, expected);
//     });
// });
// describe("Test isItAffordable", () => {
//     it("not enough money", () => {
//         let price = 10;
//         let budget = 1;
//         let expected = "You don't have enough money";
//         assert.equal(bookSelection.isItAffordable(price, budget), expected);
//     });
// });
// describe("Test isItAffordable", () => {
//     it("not enough money", () => {
//         let price = 10;
//         let budget = 9;
//         let expected = "You don't have enough money";
//         assert.equal(bookSelection.isItAffordable(price, budget), expected);
//     });
// });
// describe("Test isItAffordable", () => {
//     it("budget", () => {
//         let price = 10;
//         let budget = 50;
//         let result = budget - price;
//         let expected = `Book bought. You have ${result}$ left`;
//         assert.equal(bookSelection.isItAffordable(price, budget), expected);
//     });
// });
// describe("Test isItAffordable", () => {
//     it("budget", () => {
//         let price = 10;
//         let budget = 10;
//         let result = budget - price;
//         let expected = `Book bought. You have ${result}$ left`;
//         assert.equal(bookSelection.isItAffordable(price, budget), expected);
//     });
// });
// describe("Test suitableTitles", () => {
//     it("arrIsArr", () => {
//         let array = 10;
//         let wantedGenre = "pesho";
//         let expected = "Invalid input";
//         assert.throw(() => bookSelection.suitableTitles(array, wantedGenre), expected);
//     });
// });
// describe("Test suitableTitles", () => {
//     it("arrIsArr", () => {
//         let array = 10;
//         let wantedGenre = 1;
//         let expected = "Invalid input";
//         assert.throw(() => bookSelection.suitableTitles(array, wantedGenre), expected);
//     });
// });
// describe("Test suitableTitles", () => {
//     it("arrIsArr", () => {
//         let array = [];
//         let wantedGenre = 1;
//         let expected = "Invalid input";
//         assert.throw(() => bookSelection.suitableTitles(array, wantedGenre), expected);
//     });
// });
// describe("Test suitableTitles", () => {
//     it("isArrFull", () => {

//         let input = [
//             { title: "Te Da Vinci Code", genre: "Thriller" },
//             { title: "The D Vinci Code", genre: "Thrler" },
//             { title: "The Da Vici Coe", genre: "Th" },
//             { title: "Th Da Vici Code", genre: "Tler" }
//         ];
//         let resultArr = [
//             "Te Da Vinci Code"
//         ];
//         assert.equal(bookSelection.suitableTitles(input, "Thriller").join(" "), resultArr.join(" "));
//     });
// });