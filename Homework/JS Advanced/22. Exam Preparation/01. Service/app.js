window.addEventListener("load", solve);

function solve() {
    document.querySelector("button[type='submit']").addEventListener("click", createTask);
    let productType = document.getElementById("type-product");
    let description = document.getElementById("description");
    let name = document.getElementById("client-name");
    let phone = document.getElementById("client-phone");
    let receiveSection = document.getElementById("received-orders");
    let completedSection = document.getElementById("completed-orders");
    let clearBtn = completedSection.querySelector("button");
    clearBtn.addEventListener("click", clearTask);

    function createTask(e) {
        e.preventDefault();
        let typeValue = productType.value;
        let descriptionValue = description.value;
        let nameValue = name.value;
        let phoneValue = phone.value;
        if (!descriptionValue || !nameValue || !phoneValue) {
            return;
        }
        description.value = "";
        name.value = "";
        phone.value = "";
        createOrder(typeValue, descriptionValue, nameValue, phoneValue);
    }

    function createOrder(typeValue, descriptionValue, nameValue, phoneValue) {
        let divContainer = document.createElement("div");
        divContainer.classList.add("container");

        let h2 = document.createElement("h2");
        h2.textContent = `Product type for reapair: ${typeValue}`;

        let h3 = document.createElement("h3");
        h3.textContent = `Client information: ${nameValue}, ${phoneValue}`;

        let h4 = document.createElement("h4");
        h4.textContent = `Description of the problem: ${descriptionValue}`;

        let startButton = document.createElement("button");
        startButton.classList.add("start-btn");
        startButton.textContent = `Start repair`;
        startButton.addEventListener("click", startRepair);

        let finishButton = document.createElement("button");
        finishButton.classList.add("finish-btn");
        finishButton.addEventListener("click", finishTask);
        finishButton.setAttribute("disabled", true);
        finishButton.textContent = `Finish repair`;


        divContainer.appendChild(h2);
        divContainer.appendChild(h3);
        divContainer.appendChild(h4);
        divContainer.appendChild(startButton);
        divContainer.appendChild(finishButton);
        receiveSection.appendChild(divContainer);
    }

    function startRepair(e) {
        e.target.setAttribute("disabled", true);
        let finishBtn = e.target.parentElement.getElementsByClassName("finish-btn")[0];
        finishBtn.disabled = false;
    }

    function finishTask(e) {
        let divConteiner = e.target.parentElement;
        completedSection.appendChild(divConteiner);
        let buttons = divConteiner.querySelectorAll("button");
        buttons[0].remove();
        buttons[1].remove();
    }

    function clearTask(e) {
        let containers = completedSection.querySelectorAll(".container");
        Array.from(containers).forEach(container => container.remove());
    }
}