/// <reference path="js-console.js" />

var arr = [];

function hasProperty(obj, property) {
    var propart = typeof obj;
    for (var prop in prompt) {
        if (prop.toString() === property) {
            return true;
        }
    }
    return false;
}

function start() {
    jsConsole.writeLine(4)
    var value = hasProperty(arr, 'length');
    jsConsole.writeLine(value.toString())
}