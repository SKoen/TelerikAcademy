
function countDigit(arr, digit) {
    var thimes = 0;
    for (var i = 0; i < arr.length; i++) {
        if (digit == arr[i]) {
            thimes++;
        }
    }

    jsConsole.writeLine("Number: " + digit + " appears " + thimes + " in this array!")
}