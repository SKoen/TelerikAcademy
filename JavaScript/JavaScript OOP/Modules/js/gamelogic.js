'use strict';

var GameLogic = function(ctx){

    //Private
    var checkBorders,
        checkSnakeBody,
        gameKeys,
        checkSnakeEatApple,
        direction = 'right';

    //Public
    gameKeys = function() {
        document.addEventListener('keydown', keyDown, false);
        function keyDown(e) {
            if (e.keyCode == 39) {
                direction = 'right';
            }
            else if (e.keyCode == 37) {
                direction = 'left';
            }
            else if (e.keyCode == 38) {
                direction = 'up';
            }
            else if (e.keyCode == 40) {
                direction = 'down';
            }
        }

        return direction;
    };

    checkBorders = function(rectCordinates, snakeCordinates){
        var snakeHead = snakeCordinates[0];

        if(snakeHead.x <= rectCordinates.x+10 || snakeHead.x >= rectCordinates.x+rectCordinates.width-20 ||
            snakeHead.y <= rectCordinates.y+10 || snakeHead.y >= rectCordinates.y+rectCordinates.height-20){
            return true;
        }
        else {
            return false;
        }
    };

    checkSnakeBody = function(snakeCordinates){
        var snakeHead = snakeCordinates[0],
            length = snakeCordinates.length;

        for(var i=1; i < length; i++){
            if(snakeHead.x === snakeCordinates[i].x || snakeHead.x === snakeCordinates[i].x + 10 &&
                snakeHead.y === snakeCordinates[i].y || snakeHead.y === snakeCordinates[i].y + 10){
                return true;
            }
        }

        return false;
    };

    checkSnakeEatApple = function(snakeCordinates, apple){
        var snakeHead = snakeCordinates[0];

        if(snakeHead.x >= apple.x && snakeHead.x <= apple.x + 10 &&
            snakeHead.y >= apple.y && snakeHead.y <= apple.y + 10){
            return true;
        }

        return false;
    };

    return{
        gameKeys: gameKeys,
        checkSnakeBody: checkSnakeBody,
        checkBorders: checkBorders,
        checkSnakeEatApple: checkSnakeEatApple
    }

};