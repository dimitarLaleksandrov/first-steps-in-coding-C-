class footballTeam {
    constructor(clubName, country) {
        this.clubName = clubName;
        this.country = country;
        this.invitedPlayers = [];
    }
    newAdditions(footballPlayers) {
        footballPlayers.forEach(players => {
            let player = players.split(", ");
            player.forEach(info => {
                let [name, age, playerValue] = info.split("/");
                age = Number(age);
                playerValue = Number(playerValue);
                let findPlayer = this.invitedPlayers.find(p => p.name === name);
                if (!findPlayer) {
                    this.invitedPlayers.push({
                        name,
                        age,
                        playerValue
                    });
                } else if (findPlayer.playerValue < playerValue) {
                    findPlayer.playerValue = playerValue;
                }

            });
        });
        let sb = [];
        this.invitedPlayers.forEach(p => sb.push(p.name));
        return `You successfully invite ${sb.join(", ")}.`;
    }
    signContract(selectedPlayer) {
        let [name, playerOffer] = selectedPlayer.split("/");
        playerOffer = Number(playerOffer);
        let player = this.invitedPlayers.find(p => p.name === name);
        if (!player) {
            throw new Error(`${name} is not invited to the selection list!`);
        }

        if (playerOffer < player.playerValue) {
            let priceDifference = player.playerValue - playerOffer;
            throw new Error(`The manager's offer is not enough to sign a contract with ${name}, ${priceDifference} million more are needed to sign the contract!`);
        }
        player.playerValue = String("Bought");
        return `Congratulations! You sign a contract with ${name} for ${playerOffer} million dollars.`;
    }
    ageLimit(name, age) {
        let player = this.invitedPlayers.find(p => p.name === name);
        if (!player) {
            throw new Error(`${name} is not invited to the selection list!`);
        }
        if (player.age < age) {
            let ageDifference = age - player.age;
            if (ageDifference < 5) {
                return `${name} will sign a contract for ${ageDifference} years with ${clubName} in ${country}!`;
            } else {
                return `${name} will sign a full 5 years contract for ${clubName} in ${country}!`;
            }
        }
        if (player.age >= age) {
            return `${name} is above age limit!`;
        }
    }
    transferWindowResult() {
        let sb = "";
        sb += `Players list:\n`;
        this.invitedPlayers.sort((p => p.name).forEach(p => sb += `${p.name}-${p.playerValue}\n`));
    }
}
let fTeam = new footballTeam("Barcelona", "Spain"); 
console.log(fTeam.newAdditions(["Kylian Mbappé/23/160", "Lionel Messi/35/50", "Pau Torres/25/52"]));