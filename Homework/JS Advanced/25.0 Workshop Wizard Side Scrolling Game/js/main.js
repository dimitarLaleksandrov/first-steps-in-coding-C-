document.getElementById("startGameplay").addEventListener("click", startGame);
let startScreen = document.getElementsByClassName("start-game")[0];
let platScreen = document.getElementsByClassName("play-game")[0];
let state = initState();
let game = prepareGame();


function startGame(e) {
    startScreen.style.display = "none";
    platScreen.style.display = "block";
    start(state, game);
}