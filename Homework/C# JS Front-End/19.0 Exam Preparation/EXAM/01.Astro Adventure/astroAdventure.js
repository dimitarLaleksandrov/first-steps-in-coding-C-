function demo(input) {

    const astronauts = [];

    const astronautsCount = Number(input.shift());

    for (let i = 1; i <= astronautsCount; i++) {

        const [name, oxygen, energy] = input.shift().split(' ');

        astronauts.push({
            name,
            oxygen: Number(oxygen),
            energy: Number(energy)
        });

    }
    while (input.length > 0) {

        const command = input.shift();

        if (command === 'End') {

            break;

        }

        const [action, name, value] = command.split(' - ');

        switch (action) {
            case 'Explore':
                const energyNeedet = Number(value);
                const astonaut = astronauts.find(a => a.name === name)

                if (astonaut.energy >= energyNeedet && astonaut) {

                    astonaut.energy -= energyNeedet;
                    console.log(`${name} has successfully explored a new area and now has ${astonaut.energy} energy!`)
                } else if (astonaut) {
                    console.log(`${name} does not have enough energy to explore!`);
                }

                break;

            case 'Refuel':
                const amaunt = Number(value);
                const astonautToRefuel = astronauts.find(a => a.name === name)

                if (astonautToRefuel) {
                    const energyRecovered = Math.min(amaunt, 200 - astonautToRefuel.energy);
                    astonautToRefuel.energy += energyRecovered;

                    console.log(`${name} refueled their energy by ${energyRecovered}!`);
                }

                break;

            case 'Breathe':
                const amauntOxygen = Number(value);
                const astonautToBreathe = astronauts.find(a => a.name === name)

                if (astonautToBreathe) {
                    const oxygenRecovered = Math.min(amauntOxygen, 100 - astonautToBreathe.oxygen);
                    astonautToBreathe.oxygen += oxygenRecovered;

                    console.log(`${name} took a breath and recovered ${oxygenRecovered} oxygen!`);
                }

                break;

            default:
                break;
        }




    }

    astronauts.forEach(a => {
        console.log(`Astronaut: ${a.name}, Oxygen: ${a.oxygen}, Energy: ${a.energy}`);
    })






}
demo(['3',
    'John 50 120',
    'Kate 80 180',
    'Rob 70 150',
    'Explore - John - 50',
    'Refuel - Kate - 30',
    'Breathe - Rob - 20',
    'End'
])