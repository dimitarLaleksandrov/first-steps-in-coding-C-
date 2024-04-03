window.addEventListener("load", solve);

function solve() {

    const playerNameInput = document.getElementById('player');
    const playerscoreInput = document.getElementById('score');
    const playerRoundInput = document.getElementById('round');

    const addBtn = document.getElementById('add-btn');
    const clearBtn = document.querySelector('.clear');

    const formElemet = document.querySelector('form');

    addBtn.addEventListener('click', publish)

    function publish() {

        const isValidInput = playerNameInput.value === '' || playerscoreInput.value === '' || playerRoundInput.value === '';

        if (isValidInput) {

            return;

        }

        const reviewList = document.getElementById('sure-list');
        const scoreboardList = document.getElementById('scoreboard-list');

        const li = document.createElement('li');
        li.classList.add('dart-item');

        const articleElement = document.createElement('article');

        const nameParagraf = document.createElement('p');
        nameParagraf.textContent = playerNameInput.value;
        const nameVal = playerNameInput.value;

        const scoreParagraf = document.createElement('p');
        scoreParagraf.textContent = `Score: ${playerscoreInput.value}`;
        const scoreVal = playerscoreInput.value;


        const roundeParagraf = document.createElement('p');
        roundeParagraf.textContent = `Round: ${playerRoundInput.value}`;
        const roundVal = playerRoundInput.value;


        articleElement.appendChild(nameParagraf);
        articleElement.appendChild(scoreParagraf);
        articleElement.appendChild(roundeParagraf);

        const editBtn = document.createElement('button');
        editBtn.classList.add('btn');
        editBtn.classList.add('edit');

        editBtn.textContent = 'edit';
        editBtn.addEventListener('click', edit);

        const postBtn = document.createElement('button');
        postBtn.classList.add('btn');
        postBtn.classList.add('ok');

        postBtn.textContent = 'ok';
        postBtn.addEventListener('click', post);

        li.appendChild(articleElement);
        li.appendChild(editBtn);
        li.appendChild(postBtn);

        reviewList.appendChild(li);

        addBtn.disabled = true;

        formElemet.reset();


        function edit() {
            playerNameInput.value = nameVal;
            playerscoreInput.value = scoreVal;
            playerRoundInput.value = roundVal;

            reviewList.removeChild(li);

            addBtn.disabled = false;


        }

        function post() {

            reviewList.removeChild(li);
            li.removeChild(postBtn);
            li.removeChild(editBtn);

            scoreboardList.appendChild(li);

            addBtn.disabled = false;

            clearBtn.addEventListener('click', () => {
                location.reload();
            });

        }


    }

}