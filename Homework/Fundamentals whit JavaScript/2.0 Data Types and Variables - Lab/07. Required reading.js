function requiredReading(pageNum, pagesPherHours, daysForReading) {
    let hours = (pageNum / pagesPherHours) / daysForReading;
    console.log(hours);
}
requiredReading(212,
    20,
    2)