function findSequence() {
    var thimes = new Array(numberArray.length);
        numbers = new Array(numberArray.length);
    for (var i = 0; i < numberArray.length; i++) {
        numbers[i] = numberArray[i];
        thimes[i] = 1;
        for (var l = i; l < numberArray.length; l++) {
            if (l == numberArray.length - 1) {
                break;
            }
            if (numbers[i] == numberArray[l + 1]) {
                thimes[i]++;
            } else {
                break;
            }
        }
    }

    var maxThimes = thimes[0];
    for (var i = 1; i < thimes.length; i++) {
        if (maxThimes < thimes[i]) {
            maxThimes = thimes[i];
        }
    }

    var position = thimes.indexOf(maxThimes);
    jsConsole.write("{ ");
    for (var i = 0; i < thimes[position]; i++) {
        jsConsole.write(numbers[position] + " ");
    }

    jsConsole.write(" }");
    jsConsole.writeLine();
}