var numberArray = [2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 2, 2, 1];

function findSequence() {
    var thimes = new Array(numberArray.length);
        numbers = [];
        add = 0;
    for (var i = 0; i < numberArray.length; i++) {
        numbers[i] = [];
        numbers[i][add] = numberArray[i];
        thimes[i] = 1;
        for (var l = i + 1; l < numberArray.length; l++) {
            if (l == numberArray.length - 1) {
                break;
            }
            if (numbers[i][add] < numberArray[l]) {
                numbers[i].push(numberArray[l]);
                add++;
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
        jsConsole.write(numbers[position][i] + " ");
    }
    jsConsole.write(" }");
    jsConsole.writeLine();
}