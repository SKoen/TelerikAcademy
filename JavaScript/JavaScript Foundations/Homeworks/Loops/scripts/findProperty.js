/// <reference path="js-console.js" />

function findProperty() {
    var arr1 = [window, navigator, document];
    for (var i = 0; i < 3; i++) {
        var outTxt = "";
        var arr;
        for (var property in arr1[i]) {
            outTxt += property + " ";
        }
        arr = outTxt.split(" ");
        arr.sort();
        jsConsole.writeLine(arr1[i].toString());
        jsConsole.writeLine("Min: " + arr[1]);
        jsConsole.writeLine("Max: " + arr[arr.length - 1]);
    }
}
