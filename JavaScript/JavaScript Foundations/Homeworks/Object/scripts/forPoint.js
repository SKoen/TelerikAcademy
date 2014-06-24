/// <reference path="js-console.js" />
var x1,
    x2,
    y1,
    y2;

function shapes() {
    x1 = jsConsole.readInteger("#x1");
    x2 = jsConsole.readInteger("#x2");
    y1 = jsConsole.readInteger("#y1");
    y2 = jsConsole.readInteger("#y2");

    var distance = Math.sqrt(Math.pow(x2 - x1) + Math.pow(y2 - y1));

    jsConsole.writeLine("Distance = " + distance)
}

function buildPoint(x, y) {
    return {
        x: x,
        y: y,
    }
};

function buildLine(p1, p2) {
    return {
        p1: p1,
        p2: p2,
    }
};
