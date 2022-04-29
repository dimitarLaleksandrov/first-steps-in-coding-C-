function gramophone(nameOfTheBand, nameOfTheAlbum, nameOfTheSong) {
    let time = (nameOfTheBand.length * nameOfTheAlbum.length) * nameOfTheSong.length / 2;
    let plateRotated = Math.ceil(time / 2.5);
    console.log(`The plate was rotated ${plateRotated} times.`);
}
gramophone('Black Sabbath', 'Paranoid', 'War Pigs')