/**
 * Created by Sh0rti on 6/13/2014.
 */
var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css",
    "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC",
    "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];


var tagCloud = generateTagCloud(tags, 17, 42);
document.body.appendChild(tagCloud);

function generateTagCloud(text, minFont, maxFont) {
    var wordsCount = countWords(text);
    var div = document.createElement("div");
    div.style.width = "300px";
    div.style.border = "1px solid black";

    var min = Number.MAX_VALUE;
    var max = 0;

    for (var word in wordsCount) {
        if (wordsCount[word]>max) {
            max = wordsCount[word];
        }
        if (wordsCount[word]<min) {
            min = wordsCount[word];
        }
    }

    for (var word in wordsCount) {
        var span = document.createElement("span");

        if (min==wordsCount[word]) {
            span.style.fontSize = minFont + "px";
        }
        else if (max == wordsCount[word]) {
            span.style.fontSize = maxFont + "px";
        }
        else {
            span.style.fontSize = minFont + ((maxFont - minFont) / ((max - wordsCount[word])+1))+"px";
        }
        span.innerText = word+" ";
        div.appendChild(span);
    }

    function countWords(words) {
        var wordsCount = {};
        var word = {};
        for (var i in words) {
            word = words[i].toLowerCase();
            if (wordsCount[word]) {
                wordsCount[word]++;
            }
            else {
                wordsCount[word] = 1;
            }
        }

        return wordsCount;
    }

    return div;
}
