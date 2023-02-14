class Garden {
    constructor(spaceAvailable) {
        this.spaceAvailable = spaceAvailable;
        this.plants = [];
        this.storage = [];
    }
    addPlant(plantName, spaceRequired) {
        if (spaceRequired > this.spaceAvailable) {
            throw Error("Not enough space in the garden.");
        }
        let plant = {
            plantName,
            spaceRequired,
            ripe: false,
            quantity: 0
        }
        this.plants.push(plant);
        this.spaceAvailable -= spaceRequired;
        return `The ${plantName} has been successfully planted in the garden.`;
    }
    ripenPlant(plantName, quantity) {
        let q = Number(quantity);
        let plant = this.plants.find(p => p.plantName === plantName);
        if (!plant) {
            throw Error(`There is no ${plantName} in the garden.`);
        }
        if (plant.ripe) {
            throw Error(`The ${plantName} is already ripe.`);
        }
        if (quantity <= 0) {
            throw Error(`The quantity cannot be zero or negative.`);
        }
        plant.ripe = true;
        plant.quantity = quantity;
        let returnMSG = quantity === 1 ? `${quantity} ${plantName} has successfully ripened.` : `${quantity} ${plantName}s have successfully ripened.`;
        return returnMSG;
    }
    harvestPlant(plantName) {
        let plant = this.plants.find(p => p.plantName === plantName);
        if (!plant) {
            throw Error(`There is no ${plantName} in the garden.`);
        }
        if (!plant.ripe) {
            throw Error(`The ${plantName} cannot be harvested before it is ripe.`);
        }
        this.plants = this.plants.filter(p => p.plantName !== plantName);
        this.storage.push({
            plantName: plant.plantName,
            quantity: plant.quantity
        });
        this.spaceAvailable += plant.spaceRequired;
        return `The ${plantName} has been successfully harvested.`;
    }
    generateReport() {
        let sb = "Plants in the garden: ";
        sb += `The garden has ${ this.spaceAvailable } free space left.`;
        sb += `\n`;
        sb += `Plants in the garden: `;
        this.plants.sort((a, b) => a.plantName.localeCompare(b.plantName)).forEach(plant => sb += `${plant.plantName}, `);
        sb = sb.substring(0, sb.length - 2);
        sb += `\n`;
        if (!this.storage.length) {
            sb += `Plants in storage: The storage is empty.`;
        } else {
            sb += `Plants in storage: `;
            this.storage.forEach(plant => sb += `${plant.plantName} (${plant.quantity}), `);
        }
        sb = sb.substring(0, sb.length - 2);
        return sb;
    }
}
const myGarden = new Garden(250)
console.log(myGarden.addPlant('apple', 20));
console.log(myGarden.addPlant('orange', 200));
console.log(myGarden.addPlant('raspberry', 10));
console.log(myGarden.ripenPlant('apple', 10));
console.log(myGarden.ripenPlant('orange', 1));
console.log(myGarden.harvestPlant('orange'));
console.log(myGarden.generateReport());