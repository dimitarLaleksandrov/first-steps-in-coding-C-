window.addEventListener("load", solve);

function solve() {
    document.getElementById("form-btn").addEventListener("click", createTask)
    let firstName = document.getElementById("first-name");
    let lastName = document.getElementById("last-name");
    let age = document.getElementById("age");
    let storyTitle = document.getElementById("story-title");
    let genre = document.getElementById("genre");
    let textStory = document.getElementById("story");
    let previewSection = document.getElementById("preview-list");

    function createTask(e) {
        let formBtn = document.getElementById("form-btn");
        let firstNameValue = firstName.value;
        let lastNameValue = lastName.value;
        let ageValue = age.value;
        let storyTitleValue = storyTitle.value;
        let genreValue = genre.value;
        let textStoryValue = textStory.value;
        createPreview(firstNameValue, lastNameValue, ageValue, storyTitleValue, genreValue, textStoryValue)
        formBtn.disabled = true;
        firstName.value = "";
        lastName.value = "";
        age.value = "";
        genre.value = "";
        textStory.value = "";

    }

    function createPreview(firstName, lastName, age, storyTitle, genre, textStory) {
        let liContainer = document.createElement("li");
        let previewList = document.getElementById("preview-list");

        liContainer.classList.add("story-info");

        let article = document.createElement("article");

        let h4 = document.createElement("h4");
        h4.textContent = `Name: ${firstName} ${lastName}`;
        let p1 = document.createElement("p");
        p.textContent = `Age: ${age}`;

        let p2 = document.createElement("p");
        h4.textContent = `Title: ${storyTitle}`;

        let p3 = document.createElement("p");
        h4.textContent = `Genre: ${genre}`;

        let p4 = document.createElement("p");
        h4.textContent = `${textStory}`;

        let saveBtn = document.createElement("button");
        saveBtn.classList.add("save-btn");
        saveBtn.setAttribute("disabled", false);
        saveBtn.textContent("Save Story");
        saveBtn.addEventListener("click", saveEvent);

        let editBtn = document.createElement("button");
        editBtn.classList.add("edit-btn");
        editBtn.setAttribute("disabled", false);
        editBtn.textContent("Edit Story");
        editBtn.addEventListener("click", editEvent);

        let deleteBtn = document.createElement("button");
        deleteBtn.classList.add("delete-btn");
        deleteBtn.setAttribute("disabled", false);
        deleteBtn.textContent("Delete Story");
        deleteBtn.addEventListener("click", deleteEvent);

        article.appendChild(h4);
        article.appendChild(p1);
        article.appendChild(p2);
        article.appendChild(p3);
        article.appendChild(p4);
        liContainer.appendChild(article);
        liContainer.appendChild(saveBtn);
        liContainer.appendChild(editBtn);
        liContainer.appendChild(deleteBtn);
        previewList.appendChild(liContainer);
        previewSection.appendChild(previewList);
    }

    function editEvent(e) {
        let formBtn = document.getElementById("form-btn");
        let firstName = firstName.value;
        let lastName = lastName.value;
        let age = age.value;
        let storyTitle = storyTitle.value;
        let genre = genre.value;
        let textStory = textStory.value;
    }

    function deleteEvent(e) {
        previewSection.remove();
        let formBtn = document.getElementById("form-btn");
        formBtn.disabled = false;
    }

    function saveEvent() {

    }
}