const Service = require('./miniCrud');

let storage = new Service();

let obj1 = { name: "obj 1" };
let obj2 = { name: "obj 2" };
let obj3 = { name: "obj 3" };
let obj4 = { name: "obj 4" };
let obj5 = { name: "obj 5" };

storage.add(obj1);
storage.add(obj2);
storage.add(obj3);
storage.add(obj4);
storage.add(obj5);

console.log("getAll()");
console.log(storage.getAll());
console.log("getById()");
console.log(storage.getById("2"));
console.log("deleteById()");
storage.deleteById(2);
console.log(storage.getAll());
console.log("updateById()");
storage.updateById(3, obj2);
console.log(storage.getAll());
console.log("replaceById()");
storage.replaceById(4, obj3);
console.log(storage.getAll());
