/// <reference path="js-console.js" />

function Reverse() {
    var number = jsConsole.readInteger("#number");
        strNumber = number.toString();
    for (var i = strNumber.length - 1; i >= 0; i--) {
        jsConsole.write(strNumber[i]);
    }

    jsConsole.writeLine();
}       