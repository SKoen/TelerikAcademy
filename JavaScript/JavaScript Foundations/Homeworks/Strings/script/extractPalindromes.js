/// <reference path="js-console.js" />
var text = "Alot of text like abba or exe or some like loiol ili forrof."
jsConsole.writeLine(findPolindromes(text));

function findPolindromes(text) {
    var strArr = [];
    text = text.toLowerCase();
    text = text.replace(".", " ").replace("!", " ").replace("?", " ").replace(",", " ");
    var wordsArr = text.split(" ");
    
    for (var i = 0; i < wordsArr.length; i++) {
        var word = wordsArr[i];
        if (word.length % 2 == 0) {
            var leftPart = word.substring(0, word.length / 2),
                ridePart = reverseWord(word.substring(word.length / 2));
            if (leftPart == ridePart) {
                strArr.push(word);
            }
        }
        else {
            var leftPart = word.substring(0, word.length/2),
                ridePart = reverseWord(word.substring(word.length/2+1));
            if (leftPart == ridePart) {
                strArr.push(word);
            }
        }
    }

    return strArr;
}

function reverseWord(input) {
    var newWord = "";
    for (var i = input.length-1; i >= 0; i--) {
        newWord += input[i];
    }

    return newWord;
}
