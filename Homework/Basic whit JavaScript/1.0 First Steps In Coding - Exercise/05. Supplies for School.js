function scoolMaterials(input) {
    const pens = 5.80;
    const markers = 7.20;
    const preparation = 1.20;
    let pensPacage = Number(input[0]);
    let markersPacage = Number(input[1]);
    let litersPreparations = Number(input[2]);
    let procentReduction = Number(input[3]);
    let pensPrice = pens * pensPacage;
    let markerPrice = markers * markersPacage;
    let preparationPrice = preparation * litersPreparations;
    let sum = pensPrice + markerPrice + preparationPrice;
    let procent = procentReduction / 100;
    let endSum = sum - (sum * procent);
    console.log(endSum);
}