/// <reference path="js-console.js" />
var strText = "I send you a mail from lalo@abv.bg and i deliver some emails from pesho@gmail.com and some gosho@mail.bg.";

var arr = extractMail(strText);
jsConsole.writeLine(arr);

function extractMail(text) {
    var strArr = [],
        indexStart = text.indexOf("@");
    while (indexStart > -1) {
        var startIndex,
            endIndex;
        for (var i = indexStart; i < text.length; i++) {
            if (i == text.length-1) {
                endIndex = i;
                break;
            }
            if (text.charCodeAt(i) == 32) {
                endIndex = i;
                break;
            }
        }

        for (var i = indexStart; i > 0; i--) {
            if (text.charCodeAt(i) == 32) {
                startIndex = i;
                break;
            }
        }

        var insedeText = text.substring(startIndex, endIndex);
        strArr.push(insedeText);
        indexStart = text.indexOf("@", indexStart + 2);
    }
    return strArr;
    
}