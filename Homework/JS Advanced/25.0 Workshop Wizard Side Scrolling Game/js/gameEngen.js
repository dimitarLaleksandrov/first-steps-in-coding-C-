function start(state, game) {
    let wizzard = game.createWizzard(state);
    window.requestAnimationFrame(gameLoop.bind(null, wizzard));
}

function gameLoop(wizzard) {
    window.requestAnimationFrame(gameLoop.bind(null, wizzard));
}