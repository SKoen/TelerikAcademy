'use strict';

var StartGame = (function(id){
    var ctx = document.getElementById(id).getContext("2d"),
        direction = 'right',
        apple,
        levelUp = 10,
        development = {
            score: 0,
            level: 1,
            game: 'In Progres'
        },
        rectCordinates = {
            x: 50,
            y: 30,
            width: 700,
            height: 400
        },
        snakeCordinates = [{x: 150, y: 150}, {x: 140, y: 150}, {x: 130, y: 150}, {x: 120, y: 150},{x: 110, y: 150},{x: 100, y: 150}];

    var board = new Board(ctx),
        snake = new Snake(ctx),
        logic = new GameLogic(ctx);

    board.draw(rectCordinates);
    board.drawScore(rectCordinates,development);
    apple = board.getAppleCords(rectCordinates);
    startGame();

    function startGame(){
        board.clear();
        direction = logic.gameKeys();
        if(logic.checkSnakeEatApple(snakeCordinates, apple)){
            apple = board.getAppleCords(rectCordinates);
            development.score +=1;
        }

        if(development.score == levelUp){
            development.level += 1;
            levelUp += 10;
        }

        if(!logic.checkBorders(rectCordinates, snakeCordinates)){
            setTimeout(startGame, 150);
        }
        else{
            development.game = 'OVER';
        }

        board.draw(rectCordinates);
        board.drawApple(apple);
        snake.draw(snakeCordinates);
        snake.move(snakeCordinates, direction);
        board.drawScore(rectCordinates, development);
    }

    return {
        start: startGame
    }
});