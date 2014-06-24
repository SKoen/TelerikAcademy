
function calculate() {
    var a = jsConsole.readInteger("#a");
        b = jsConsole.readInteger("#b");
        c = jsConsole.readInteger("#c");
        x = null;
        x1 = null;
        x2 = null;
    if (a == 0) {
        if (b == 0) {
            jsConsole.writeLine("Have 0 roots!");
        } else {
            if (c == 0) {
                jsConsole.writeLine("Have 0 roots!");
            } else {
                x = -c / b;
                jsConsole.writeLine("X = " + x);
            }
        }
    } else if (b == 0) {
        x = Math.sqrt(c / a);
        jsConsole.writeLine("X = " + Math.floor(x));
    } else {
        if (b == 0) {
            x = Math.sqrt(-c / a);
            jsConsole.writeLine("X = " + x);
        } else {
            if (c == 0) {
                x1 = 0;
                x2 = b / a;
                jsConsole.writeLine("X1 = " + Math.floor(x1) + " X2 = " + Math.floor(x2));
            } else {
                var d = -b ^ 2 - 4 * a * c;
                x1 = (-b + Math.sqrt(d)) / 2 * a;
                x2 = (-b - Math.sqrt(d)) / 2 * a;
                jsConsole.writeLine("X1 = " + Math.floor(x1) + " X2 = " + Math.floor(x2));
            }
        }
    }
}