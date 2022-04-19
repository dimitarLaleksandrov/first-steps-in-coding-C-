function trekkingMania(input) {
    let grupeNum = Number(input[0]);
    let allPpl = 0;
    let musalaPpl = 0;
    let monblanPpl = 0;
    let kilimangaroPpl = 0;
    let k2Ppl = 0;
    let everesPpl = 0;
    let index = 1;
    for (let i = 0; i < grupeNum; i++) {
        let numberOfPpl = Number(input[index]);
        index++;
        if (numberOfPpl <= 5) {
            musalaPpl += numberOfPpl;
        } else if (numberOfPpl > 5 && numberOfPpl <= 12) {
            monblanPpl += numberOfPpl;
        } else if (numberOfPpl > 12 && numberOfPpl <= 25) {
            kilimangaroPpl += numberOfPpl;
        } else if (numberOfPpl > 25 && numberOfPpl <= 40) {
            k2Ppl += numberOfPpl;
        } else if (numberOfPpl > 40) {
            everesPpl += numberOfPpl;
        }
        allPpl += numberOfPpl;
    }
    let musalaProcent = ((musalaPpl / allPpl) * 100).toFixed(2);
    let monblantProcent = ((monblanPpl / allPpl) * 100).toFixed(2);
    let kilimangaroProcentt = ((kilimangaroPpl / allPpl) * 100).toFixed(2);
    let k2procent = ((k2Ppl / allPpl) * 100).toFixed(2);
    let everestProcent = ((everesPpl / allPpl) * 100).toFixed(2);
    console.log(`${musalaProcent}%`);
    console.log(`${monblantProcent}%`);
    console.log(`${kilimangaroProcentt}%`);
    console.log(`${k2procent}%`);
    console.log(`${everestProcent}%`);
}