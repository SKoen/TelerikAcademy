function count() {
    var divs = document.getElementsByTagName("div");
        count = 0;
    for (var div in divs) {
        count++;
    }

    jsConsole.writeLine("Divs: " + count);
}