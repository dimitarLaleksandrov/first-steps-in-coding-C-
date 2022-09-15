function stringLength(string1, string2, string3) {
    let allLength = string1.length + string2.length + string3.length
    let averageLength = Math.floor(allLength / 3);
    console.log(allLength);
    console.log(averageLength);
}
stringLength('chocolate', 'ice cream', 'cake');