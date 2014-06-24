function findTheNumbers() {
    var numbersArray = jsConsole.read("#number");
        numbers = numbersArray.split(",");
        max = numbers[0];
        min = numbers[0];
    for (var i = 0; i < numbers.length; i++) {
        if (max < numbers[i]) {
            max = numbers[i];
        }
        if (min > numbers[i]) {
            min = numbers[i];
        }
    }
    jsConsole.writeLine("Max Number is: " + max + " Min Number is: " + min);
}
