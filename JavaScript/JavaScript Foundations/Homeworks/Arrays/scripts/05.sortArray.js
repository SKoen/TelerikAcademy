function sort() {
    for (var i = 0; i < numberArray.length; i++) {
        var min = numberArray[i];
        for (var l = i + 1; l < numberArray.length; l++) {
            if (min > numberArray[l]) {
                numberArray[i] = numberArray[l];
                numberArray[l] = min;
                min = numberArray[i];
            }
        }
    }

    jsConsole.writeLine(numberArray)
}