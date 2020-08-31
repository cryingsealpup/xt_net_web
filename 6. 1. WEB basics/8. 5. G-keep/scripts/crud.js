"use strict";
class Service {
  constructor() {
    this.data = new Array();
    this.id = 0;
  }

  add(obj) {
    if (obj != null && typeof obj == "object") {
      this.id++;
      obj.id = this.id;
      this.data.push(obj);
    }
  }

  getById(id) {
    for (let i = 0; i < this.data.length; i++) {
      if (this.data[i].id == id && id != null && typeof id == "string")
        return this.data[i];
    }
    return null;
  }

  getAll() {
    return this.data;
  }

  deleteById(id) {
    for (let i = 0; i < this.data.length; i++) {
      if (id != null && this.data[i].id == id) {
        this.data.splice(i, 1);
        return this.data[i];
      }
    }
    return null;
  }

  replaceById(id, obj) {
    if (id != null && obj != null) {
      for (let i = 0; i < this.data.length; i++) {
        if (this.data[i].id == id) {
          obj.id = id.toString();
          this.data[i] = obj;
        }
      }
    }
  }

  updateById(id, obj) {
    if (id != null && obj != null) {
      for (let i = 0; i < this.data.length; i++) {
        if (this.data[i].id == id) {
          for (let prop in obj) {
            this.data[i][prop] = obj[prop];
          }
        }
      }
    }
  }
};

export{ Service };