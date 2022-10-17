function townPopulation(input) {
    let towns = input.map(el => {
        let data = el.split(` <-> `);
        return {
            name: data[0],
            populacion: Number(data[1])
        };

    });
    let regestry = {};
    for (let town of towns) {
        if (regestry[town.name] === undefined) {
            regestry[town.name] = town.populacion;
        } else {
            regestry[town.name] += town.populacion;
        }
    }
    console.log(regestry);
}
townPopulation(['Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000'
]);