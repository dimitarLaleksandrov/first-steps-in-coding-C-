function repainting(input) {
    const nailon = 1.50;
    const paint = 14.50;
    const thinner = 5.00;
    const bagCost = 0.40;
    let neededNailon = Number(input[0]);
    let paintNeedet = Number(input[1]);
    let thinnerNeedet = Number(input[2]);
    let howersForTheCrafter = Number(input[3]);
    let sumForMaterials = (nailon * (neededNailon + 2)) + ((paintNeedet + (paintNeedet * 0.10)) * paint) + (thinner * thinnerNeedet) + bagCost;
    let crafterSum = (sumForMaterials * 0.30) * howersForTheCrafter;
    let allSum = crafterSum + sumForMaterials;
    console.log(allSum);
}