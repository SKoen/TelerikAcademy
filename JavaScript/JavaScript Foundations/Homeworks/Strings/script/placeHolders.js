/// <reference path="string-extensions.js" />
/// <reference path="js-console.js" />
var frmt = '{0}, {1}, {0} text {2}';
var words = ["1", "Pesho", "Gosho"];

var formated = stringFormat(frmt, words);
jsConsole.writeLine(formated);

function stringFormat(text,wordsArr){
    var strBuilder = buildStringBuilder();
    var beggining = 0;
    var index = text.indexOf("{");
    while (index>-1) {
        var number = parseInt(text.substr(index + 1, 1));
        strBuilder.append(text.substring(beggining, index - 1) + " ");
        strBuilder.append(wordsArr[number] + "");
        beggining = index + 3;
        index = text.indexOf("{",index+1);
    }
    return strBuilder.toString();
}

function buildStringBuilder() {
    return {
        strs: [],
        len: 0,
        append: function (str) {
            this.strs[this.len++] = str;
            return this;
        },
        toString: function () {
            return this.strs.join("");
        }
    };
}