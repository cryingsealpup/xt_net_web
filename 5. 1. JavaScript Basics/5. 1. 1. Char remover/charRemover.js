"use strict";
function removeChars(str) {
    const punct = [' ', '    ', '?', '!', ':', ',', '.'];
    let words = [];
    let chars = [];
    let array = str.split('');

    for (let i = 0; i < punct.length; i++) {
        if (str.includes(punct[i])) { words = str.split(punct[i]) };
    };

    for (let i = 0; i < words.length; i++) {
        let str = String(words[i]);
        for (let j = 0; j < str.length; j++) {
            if (str.split(str[j]).length - 1 > 1) {
                if (!chars.includes(str[j])) { chars.push(str[j]); };
            }
        }
    };
    for (let i = 0; i < array.length; i++) {
        for (let j = 0; j < chars.length; j++) {
            if (array[i] == chars[j]) {
                array.splice(i, 1);
            }
        }
    }
    return array.join('');
}

console.log(removeChars("У попа была собака"))