function initState() {
    let posY = Math.floor(Math.random() * 1000);
    return {
        player: "Mitko",
        score: 0,
        wizzard: {
            width: 82,
            height: 100,
            posY
        }
    };
}