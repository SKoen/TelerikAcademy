function print() {
    var number = jsConsole.readInteger("#number");
    for (var i = 0; i < number; i++) {
        jsConsole.writeLine(i+1);
    }
}