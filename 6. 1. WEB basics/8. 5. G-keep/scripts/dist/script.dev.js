"use strict";

var _crud = require("./crud.js");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var storage = new _crud.Service();

var Note = function Note(title, text) {
  _classCallCheck(this, Note);

  this.title = title;
  this.text = text;
};

var notes = document.getElementById("notes");

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
  var title = document.getElementById("noteHeadCreate").value;
  var text = document.getElementById("noteTextCreate").textContent;
  if (title === "" && text === "") alert("Заметка не может быть пустой");else {
    var note = new Note(title, text);
    showModalWindow();
    storage.add(note);
    printNote(note);
    var noteId = document.getElementById(note.id);
    noteId.addEventListener("click", openChangeWindow);
  }
}

var changeNoteId;

function changeNote() {
  var title = document.getElementById("noteHeadChange").value;
  var text = document.getElementById("noteTextChange").textContent;
  if (title === "" && text === "") alert("Заметка не может быть пустой");else {
    storage.replaceById(changeNoteId, new Note(title, text));
    var note = document.getElementById(changeNoteId);
    note.querySelector(".noteHead").textContent = title;
    note.querySelector(".noteText").textContent = text;
    notes.prepend(note);
    showForm(document.getElementById("changeForm"), false);
  }
}

function openChangeWindow() {
  if (event.target.id != "delete") {
    changeNoteId = this.id;
    var note = storage.getById(changeNoteId);
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
  var divnote = document.createElement("div");
  divnote.classList.add("note");
  divnote.id = note.id;
  var notetitle = document.createElement("div");
  notetitle.classList.add("noteHead");
  notetitle.innerHTML = note.title;
  var noteText = document.createElement("p");
  noteText.classList.add("noteText");
  noteText.innerHTML = note.text;
  var buttonDelete = document.createElement("div");
  buttonDelete.innerHTML = '<span id = "delete" class="material-icons"> delete </span>';
  buttonDelete.classList.add("deleteButton");
  divnote.append(notetitle);
  divnote.append(noteText);
  divnote.append(buttonDelete);
  notes.prepend(divnote);
  var buttonDeleteNote = document.getElementById("delete");
  buttonDeleteNote.addEventListener("click", function () {
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
  var blocker = document.createElement("div");
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