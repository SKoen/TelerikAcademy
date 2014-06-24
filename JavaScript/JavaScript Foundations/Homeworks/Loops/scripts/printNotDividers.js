function printNotDividers() {
    var number = jsConsole.readInteger("#number");
    for (var i = 0; i <= number; i++) {
        if (i % 7 == 0 && i % 3 == 0) {

        } else {
            jsConsole.writeLine(i);
        }
    }
}