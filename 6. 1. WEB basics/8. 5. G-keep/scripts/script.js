import { Service } from "./crud.js";
let storage = new Service();

class Note {
    constructor(title, text) {
        this.title = title;
        this.text = text;
    }
}

let notes = document.getElementById("notes");

function showModalWindow() {
    switch (event.target.id) {
        case "addNote":
            showForm(document.getElementById("addForm"), true);
            break;
        case "create":
        case "addFormClose":
            showForm(document.getElementById("addForm"), false);
            clearCreateForm();
            break;
        case "close":
            showForm(document.getElementById("changeForm"), false);
            break;
    }
}

function createNote() {
    let title = document.getElementById("noteHeadCreate").value;
    let text = document.getElementById("noteTextCreate").textContent;
    if (title === "" && text === "")
        alert("Заметка не может быть пустой");
    else {
        let note = new Note(title, text);
        showModalWindow();
        storage.add(note);
        printNote(note);
        let noteId = document.getElementById(note.id);
        noteId.addEventListener("click", openChangeWindow);
    }
}
let changeNoteId;
function changeNote() {
    let title = document.getElementById("noteHeadChange").value;
    let text = document.getElementById("noteTextChange").textContent;
    if (title === "" && text === "") 
        alert("Заметка не может быть пустой");
    else {
        storage.replaceById(changeNoteId, new Note(title, text));
        let note = document.getElementById(changeNoteId);
        note.querySelector(".noteHead").textContent = title;
        note.querySelector(".noteText").textContent = text;
        notes.prepend(note);
        showForm(document.getElementById("changeForm"), false);
    }
}

function openChangeWindow() {
    if (event.target.id != "delete") {
        changeNoteId = this.id;
        let note = storage.getById(changeNoteId);
        document.getElementById("noteHeadChange").value = note.title;
        document.getElementById("noteTextChange").textContent = note.text;
        showForm(document.getElementById("changeForm"), true);
    }
}

function clearCreateForm() {
    document.getElementById("noteHeadCreate").value = "";
    document.getElementById("noteTextCreate").textContent = "";
}

function printNote(note) {
    let divnote = document.createElement("div");
    divnote.classList.add("note");
    divnote.id = note.id;
    let notetitle = document.createElement("div");
    notetitle.classList.add("noteHead");
    notetitle.innerHTML = note.title;
    let noteText = document.createElement("p");
    noteText.classList.add("noteText");
    noteText.innerHTML = note.text;
    let buttonDelete = document.createElement("div");
    buttonDelete.innerHTML =
        '<span id = "delete" class="material-icons"> delete </span>';
    buttonDelete.classList.add("deleteButton");
    divnote.append(notetitle);
    divnote.append(noteText);
    divnote.append(buttonDelete);
    notes.prepend(divnote);
    let buttonDeleteNote = document.getElementById("delete");
    buttonDeleteNote.addEventListener("click", () => {
        deleteNote(note.id);
    });
}

function deleteNote(id) {
    if (confirm("Подтвердите удаление")) {
        document.getElementById(id).remove();
        storage.deleteById(id);
    }
}

function showForm(elem, on) {
    if (on) {
        elem.classList.remove("disable");
        block();
    } else {
        elem.classList.add("disable");
        hideBlocker();
    }
}

function block() {
    let blocker = document.createElement("div");
    blocker.id = "blocker";
    document.body.append(blocker);
}

function hideBlocker() {
    document.getElementById("blocker").remove();
}

document.getElementById("addNote").addEventListener("click", showModalWindow);
document.getElementById("addFormClose").addEventListener("click", showModalWindow);
document.getElementById("create").addEventListener("click", createNote);
document.getElementById("close").addEventListener("click", showModalWindow);
document.getElementById("save").addEventListener("click", changeNote);
