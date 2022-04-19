function requiredReading(input) {
    let pages = Number(input[0]);
    let pagesHaveBeenReadet = Number(input[1]);
    let dataNum = Number(input[2]);
    let timeForOnePage = pages / pagesHaveBeenReadet;
    let howersNeedet = timeForOnePage / dataNum;
    console.log(howersNeedet);
}