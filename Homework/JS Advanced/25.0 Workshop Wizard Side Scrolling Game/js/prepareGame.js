function prepareGame() {
    let platScreen = document.getElementsByClassName("play-game")[0];
    return {
        createWizzard(initState) {
            let wizzardElement = document.createElement("div");
            wizzardElement.style.backgroundImage = "url(./resursez/wizard.png)";
            wizzardElement.style.position = "absolute";
            wizzardElement.style.width = initState.wizzard.width + "px"
            wizzardElement.style.width = initState.wizzard.height + "px"
            wizzardElement.style.top = initState.wizzard.top;
            platScreen.appendChild(wizzardElement);
        }
    }
}