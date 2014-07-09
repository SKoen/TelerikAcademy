/**
 * Created by Sh0rti on 6/30/2014.
 */
'use strict';

var specialConsole = (function () {
    var console;
    var spanTemplate = document.createElement('span');

    function createConsole(parentSelector){
        var parent = document.querySelector(parentSelector);
        var div = document.createElement('div');
        div.style.width = '900px';
        div.style.height = '600px';
        div.style.fontFamily = 'consolas';
        div.style.fontSize = '18px';
        div.style.color = 'white';
        div.style.backgroundColor = 'black';
        div.style.wordWrap = 'break-word';

        console = div;
        parent.appendChild(console);
    }

    function getPlaceholders(args){
        var placeholders = [];
        for (var i = 1; i < args.length; i++) {
            placeholders.push(args[i]);
        }

        return placeholders;
    }

    function formatString(str, args){
        var current;
        for (var i = 0, placeholder = 0; i < args.length; i++, placeholder++) {
            current = '\{' + placeholder + '\}';
            str = str.replace(current, args[i].toString(), 'g');
        }

        return str;
    }

    function writeLine(str) {
        var line = spanTemplate.cloneNode(true);
        if (arguments.length > 1){
            var argsArray = getPlaceholders(arguments);
            str = formatString(str, argsArray);
        }

        line.innerText = str + '';
        console.appendChild(line);
        console.appendChild(document.createElement('br'));
    }

    return {
        createConsole : createConsole,
        writeLine : writeLine,
        writeError: writeLine,
        writeWarning : writeLine
    }

});

specialConsole().createConsole('#container');
specialConsole().writeLine("Message: hello");
//logs to the console "Message: hello"
specialConsole().writeLine("Message: {0}", "hello");
//logs to the console "Message: hello"
specialConsole().writeError("Error: {0}", "Something happened");
specialConsole().writeWarning("Warning: {0}", "A warning");