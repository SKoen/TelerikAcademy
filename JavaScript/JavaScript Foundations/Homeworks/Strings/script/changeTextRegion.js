/// <reference path="js-console.js" />
var strText = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. "+
                "We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

strText = upCase(strText);
strText = mixCase(strText);
strText = lowCase(strText);
jsConsole.writeLine(strText);

function upCase(text) {
    var indexStart = text.indexOf("<upcase>");
    while (indexStart > -1) {
        var insedeText = text.substring(indexStart + 8, text.indexOf("</upcase>", indexStart))
        var upperText = insedeText.toUpperCase();
        text = text.replace(insedeText, upperText);
        indexStart = text.indexOf("<upcase>", indexStart + 1);
    }
    return text;
}

function mixCase(text) {
    var indexStart = text.indexOf("<mixcase>");
    while (indexStart > -1) {
        var insedeText = text.substring(indexStart + 9, text.indexOf("</mixcase>", indexStart));
        var mixedText = new String(insedeText);
        for (var i = 0; i < mixedText.length ; i++) {
            if (i % 2 == 0) {
                mixedText = mixedText.replace(mixedText[i], mixedText[i].toUpperCase())
            }
            else {
                mixedText = mixedText.replace(mixedText[i], mixedText[i].toLowerCase())
            }
        }
        text = text.replace(insedeText, mixedText);
        indexStart = text.indexOf("<mixcase>", indexStart + 1);
    }
    return text;
}

function lowCase(text) {
    var indexStart = text.indexOf("<lowcase>");
    while (indexStart > -1) {
        var insedeText = text.substring(indexStart + 9, text.indexOf("</lowcase>", indexStart));
        var lowerText = insedeText.toLowerCase();
        text = text.replace(insedeText, lowerText);
        indexStart = text.indexOf("<lowcase>", indexStart + 1);
    }
    return text;
}