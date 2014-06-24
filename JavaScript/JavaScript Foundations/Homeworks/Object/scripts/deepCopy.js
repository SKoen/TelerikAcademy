/// <reference path="js-console.js" />
var obj = {
    par1: 2,
    par2: true,
    par3: "f",
}

var b = Object.create(obj);
for (var i in b) {
    jsConsole.write(b[i] + " ");
}
jsConsole.writeLine();

function clone(obj) {
    if (obj == null || "Object" != typeof obj) {
        return obj;
    }

    if (obj instanceof Array) {
        var copy = [];
        for (var i = 0 ; i < obj.length ; i++) {
            copy[i] = clone(obj[i]);
        }
        return copy;
    }

    if (obj instanceof Object) {
        var copy = {};
        for (var attr in obj) {
            if (obj.hasOwnProperty(attr)) {
                copy[attr] = clone(obj[attr]);
            }
        }
        return copy;
    }
    throw new Error("Unable copy format!");
}

var c = clone(obj);

for (var i in c) {
    jsConsole.write(c[i] + " ");
}
jsConsole.writeLine();