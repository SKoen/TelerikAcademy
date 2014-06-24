function sort() {
    var firstNumber = jsConsole.readInteger("#firstNumber");
        secondNumber = jsConsole.readInteger("#secondNumber");
        thurdNumber = jsConsole.readInteger("#thurdNumber");
        first = firstNumber;
        second = secondNumber;
        thurd = thurdNumber;
    if (firstNumber > secondNumber) {
        if (secondNumber > thurdNumber) {
            first = thurdNumber;
            second = secondNumber;
            thurd = firstNumber;
        }
        else {
            if (firstNumber >= thurdNumber) {
                first = secondNumber;
                second = thurdNumber;
                thurd = firstNumber;
            }
            else {
                first = secondNumber;
                second = firstNumber;
                thurd = thurdNumbe;
            }
        }
    }
    else {
        if (secondNumber > thurdNumber) {
            first = firstNumber;
            second = thurdNumber;
            thurd = secondNumber;
        }
        else {
            first = firstNumber;
            second = secondNumber;
            thurd = thurdNumber;
        }
    }

    jsConsole.writeLine("Sorted Numbers: " + first + "," + second + "," + thurd);
}