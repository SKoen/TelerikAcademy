function sing() {
    var firstNumber = jsConsole.readInteger("#firstNumber");
        secondNumber = jsConsole.readInteger("#secondNumber");
        thurdNumber = jsConsole.readInteger("#thurdNumber");
        sing = "";
    if (firstNumber > 0) {
        if (secondNumber > 0) {
            if (thurdNumber > 0) {
                sing = "+";
            }
            else {
                sing = "-";
            }
        }
        else {
            if (thurdNumber > 0) {
                sing = "-";
            }
            else {
                sing = "+";
            }
        }
    }
    else {
        if (secondNumber > 0) {
            if (thurdNumber > 0) {
                sing = "-";
            }
            else {
                sing = "+";
            }
        }
        else {
            if (thurdNumber > 0) {
                sing = "+";
            }
            else {
                sing = "-";
            }
        }
    }

    jsConsole.writeLine("Numbers: (" + firstNumber + "," + secondNumber + "," + thurdNumber + ") have: " + sing + " sing!");
}