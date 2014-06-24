/// <reference path="js-console.js" />

function findOccurrences(text, word, isCaseSensitive) {
    function getOccurrencesInsensitive(word) {
        var count = 0;
            wordsInText = text.split(/\W+/);
        for (var i = 0; i < wordsInText.length; i++) {
            if (word.toLowerCase() == wordsInText[i].toLowerCase()) {
                count++;
            }
        }

        return count;
    }

    function getOccurrencesSensitive(word) {
        var count = 0;
            wordsInText = input.split(/\W+/);
        for (var i = 0; i < wordsInText.length; i++) {
            if (word == wordsInText[i]) {
                count++;
            }
        }

        return count;
    }

    switch (arguments.length) {
        case 2: getOccurencesInsensitive();
            break;
        case 3: isCaseSensitive ? getOccurrencesSensitive(word) : getOccurrencesInsensitive(word);
            break;
        default:
            break;
    }
}
