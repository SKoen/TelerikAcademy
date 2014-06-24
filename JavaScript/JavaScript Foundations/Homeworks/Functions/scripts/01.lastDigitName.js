function find() {
    var number = jsConsole.readInteger("#number");
        strNumber = number.toString();
        thisNumber = Number(strNumber[strNumber.length - 1]);
    switch (thisNumber) {
        case 0: thisNumber = "Zero";
            break;
        case 1: thisNumber = "One";
            break;
        case 2: thisNumber = "Two";
            break;
        case 3: thisNumber = "Three";
            break;
        case 4: thisNumber = "Four";
            break;
        case 6: thisNumber = "Six";
            break;
        case 7: thisNumber = "Seven";
            break;
        case 8: thisNumber = "Eigth";
            break;
        case 9: thisNumber = "Nine";
            break;
        case 5: thisNumber = "Five";
            break;
        default: thisNumber = "Not a Number!";
            break;
    }
    jsConsole.writeLine(thisNumber);
}