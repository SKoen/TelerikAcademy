/// <reference path="js-console.js" />

 var arr = [];
     newName = "";

function nameOfNumber() {
    var name = jsConsole.readInteger('#number');
    nameString = name.toString();
    for (var index = 0; index < nameString.length; index++) {
        arr[index] = nameString[index];
    }

    if (arr.length == 1) {
        getChar(Number(arr[0]));
        jsConsole.writeLine(newName);
        newName = "";
        arr = [];
    } else if (arr.length == 2) {
        if (name > 11 && name < 20) {
            getChar(name);
        } else {
            getCharTEEN(Number(arr[0]));
            newName += " "
            getChar(Number(arr[1]));
        }
        jsConsole.writeLine(newName);
        newName = "";
        arr = [];
    } else if (arr.length == 3) {
        if (name == 100 || name == 200 || name == 300 || name == 400 || name == 500 || name == 600 ||
                name == 700 || name == 800 || name == 900) {
            getChar(Number(arr[0]));
            newName += " hundred";
        } else if (Number(arr[1] + arr[2]) < 20) {
            getChar(Number(arr[0]));
            newName += " hundred and ";
            getChar(Number(arr[1] + arr[2]));
        } else {
            getChar(Number(arr[0]));
            newName += " hundred and ";
            getCharTEEN(Number(arr[1]));
            newName += " "
            getChar(Number(arr[2]));
        }
        jsConsole.writeLine(newName);
        newName = "";
        arr = [];
    } else {
        jsConsole.writeLine("Too Long Number!");
    }
   
}

function getChar(number) {
    switch (number) {
        case 0: newName += "Zero";
            break;
        case 1: newName += "One";
            break;
        case 2: newName += "Two";
            break;
        case 3: newName += "Three";
            break;
        case 4: newName += "Four";
            break;
        case 5: newName += "Five";
            break;
        case 6: newName += "Six";
            break;
        case 7: newName += "Seven";
            break;
        case 8: newName += "Eigth";
            break;
        case 9: newName += "Nine";
            break;
        case 11: newName += "Eleven";
            break;
        case 12: newName += "Twolve";
            break;
        case 13: newName += "Thirteen";
            break;
        case 14: newName += "Forteenth";
            break;
        case 15: newName += "Fiveteenth";
            break;
        case 16: newName += "Sixteenth";
            break;
        case 17: newName += "Seventeenth";
            break;
        case 18: newName += "Eigthteenth";
            break;
        case 19: newName += "Nineteenth";
            break;
        default:
            break;
    }
}

function getCharTEEN(number) {
    switch (number) {
        case 2: newName += "Twenty";
            break;
        case 3: newName += "Thurty";
            break;
        case 4: newName += "Fourty";
            break;
        case 5: newName += "Fivety";
            break;
        case 6: newName += "Sixty";
            break;
        case 7: newName += "Seventy";
            break;
        case 8: newName += "Eighty";
            break;
        case 9: newName += "Ninety";
            break;
        default:
            break;
    }
}