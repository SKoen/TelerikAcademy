/**
 * Created by Sh0rti on 6/30/2014.
 */
'use strict';

var moveDivModule = (function(){
    var angle = 10;
    var angle2 = 0;
    move();
    function move(){
            angle2 += 0.3;
            var items = document.getElementsByClassName("item");
            for(var i = 0; i < items.length; i++){
                var item = items[i]

                item.style.left = (300 + 150 * Math.cos(angle2)) + "px";
                item.style.top = (200 + 150 * Math.sin(angle2)) + "px";

                angle2+=5;
            }
            setTimeout(move, 300);
    };

    function createDiv(){
        var x = Math.round(Math.cos(angle) * 100);
        var y = Math.round(Math.sin(angle) * 100);
        angle+=60;
        var newDiv = document.createElement('div');
        newDiv.style.border = "2px solid " + generateColor();
        newDiv.style.backgroundColor = generateColor() + '';
        newDiv.style.width = "40px";
        newDiv.style.height = "40px";
        newDiv.style.top = (200 + y) + "px";
        newDiv.style.left = (300 + x) + "px";
        newDiv.style.position = "absolute";
        newDiv.borderRadius = '10px';
        newDiv.className = "item";
        var el = document.getElementById('container');
        el.appendChild(newDiv);
    }

    function generateColor(){
        var red = Math.floor((Math.random() * 255) + 1);
        var green = Math.floor((Math.random() * 255) + 1);
        var blue = Math.floor((Math.random() * 255) + 1);
        return "rgb("+ red + ',' + green + ',' + blue +')';
    }

    return{
        createDiv: createDiv(),
        move: move()
    }
});


