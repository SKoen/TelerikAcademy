'use strict';

var Board = (function(ctx){

    //Private
    var draw,
        drawScore,
        drawApple,
        clear,
        getAppleCords;

    //Public
    draw = function(rectCordinates){
        ctx.beginPath();
        ctx.fillStyle = '37BEED';
        ctx.strokeStyle = '37EDA9';
        ctx.lineWidth = 10;
        ctx.rect(rectCordinates.x, rectCordinates.y, rectCordinates.width, rectCordinates.height);
        ctx.stroke();
        ctx.fill();
    };

    drawScore = function(rectCordinates, development){
        var x = rectCordinates.x + 20,
            y = rectCordinates.y + rectCordinates.height + 35,
            width = 100;

        ctx.beginPath();
        ctx.strokeStyle = '94F6AD';
        ctx.rect(x, y-20, width+550, width-55);
        ctx.stroke();

        ctx.font = '26px Calibri';
        ctx.fillStyle = 'black';
        ctx.fillText('Score: ' + development.score, x+25, y+10);
        ctx.fillText('Level: ' + development.level, x+220, y+10);
        ctx.fillText('Game: ' + development.game, x+420, y+10);
    };

    clear = function(){
        ctx.clearRect(0, 0, 800, 500);
    };

    getAppleCords = function(rectCordinates){
        return {
            x: randomGenerathor(rectCordinates.width-60, rectCordinates.x+10),
            y: randomGenerathor(rectCordinates.height-60, rectCordinates.y+10)
        }
    };

    drawApple = function(apple){
        var x = apple.x,
            y = apple.y,
            appleWidth = 10;

        ctx.fillStyle = 'white';
        ctx.fillRect(x, y, appleWidth, appleWidth);

    };

    function randomGenerathor(from, to){
        return Math.floor(Math.random() * from) + to;
    }

    return{
        draw: draw,
        clear: clear,
        drawScore: drawScore,
        drawApple: drawApple,
        getAppleCords: getAppleCords
    }
});