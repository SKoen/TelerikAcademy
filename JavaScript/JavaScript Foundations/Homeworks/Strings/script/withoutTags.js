/// <reference path="js-console.js" />
var strText = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";

strText = removeTags(strText);
jsConsole.writeLine(strText);

function removeTags(text) {
    var indexStart = text.indexOf("<");
    while (indexStart > -1) {
        var insedeText = text.substring(indexStart, text.indexOf(">", indexStart)+1)
        var upperText = " ";
        text = text.replace(insedeText, upperText);
        indexStart = text.indexOf("<", indexStart + 1);
    }
    return text;
}