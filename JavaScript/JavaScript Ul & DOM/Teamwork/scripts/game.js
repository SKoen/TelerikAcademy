/**
 * Created by Sh0rti on 6/18/2014.
 */

////Elements

//Getting DOM elements
var ball = document.getElementById("ball");
var message = document.getElementById("message");

var GAME_FIELD_WIDTH = 1200,
    GAME_FIELD_HEIGHT = 550,
    SPEED = 10;


//Board
var stage = new Kinetic.Stage({
    container: 'container',
    width: GAME_FIELD_WIDTH,
    height: GAME_FIELD_HEIGHT
});
var layer = new Kinetic.Layer();
var background = new Kinetic.Layer();
stage.add(background);

var canvasBackgroundImage = new Image();
canvasBackgroundImage.onload = function() {
    var backgroundImage = new Kinetic.Image({
        x: 0,
        y: 0,
        image: canvasBackgroundImage,
        width: GAME_FIELD_WIDTH,
        height: GAME_FIELD_HEIGHT
    });
    background.add(backgroundImage);
    background.draw();
};
canvasBackgroundImage.src = './img/background.png';

var boardX = GAME_FIELD_WIDTH / 2,
    boardY = 500,
    boardWidth = 150,
    height = 25,
    radius = 14,
    boardSpeed = SPEED,
    inertia = 0.80;

var board = new Kinetic.Shape({
    sceneFunc: function (context) {
        context.beginPath();
        context.moveTo(boardX + radius, boardY);
        context.lineTo(boardX + boardWidth - radius, boardY);
        context.quadraticCurveTo(boardX + boardWidth, boardY, boardX + boardWidth, boardY + radius);
        context.lineTo(boardX + boardWidth, boardY + height - radius);
        context.quadraticCurveTo(boardX + boardWidth, boardY + height, boardX + boardWidth - radius, boardY + height);
        context.lineTo(boardX + radius, boardY + height);
        context.quadraticCurveTo(boardX, boardY + height, boardX, boardY + height - radius);
        context.lineTo(boardX, boardY + radius);
        context.quadraticCurveTo(boardX, boardY, boardX + radius, boardY);
        context.closePath();
        context.fillStrokeShape(this);
    },
    fill: 'red',
    stroke: 'black',
    strokeWidth: 2
});

layer.add(board);
stage.add(layer);

//Ball

var ballRadius = ball.r.baseVal.value;
var ballX;
var ballY;
var previousBallPosition = { x: 0, y: 0 };
var ballDirectionX;
var ballDirectionY;
var ballSpeed = SPEED;

// Bricks
var svgns = "http://www.w3.org/2000/svg";
var svg = document.getElementById("svgRoot");
var bricks = [];
var destroyedBricksCount;
var brickWidth = 60;
var brickHeight = 25;
var bricksRows = 5;
var bricksCols = 15;
var bricksMargin = 15;
var bricksTop = 20;
var wallMargin = 50;
var x = 0;
var y = 0;

// Misc.
var minX = ballRadius;
var minY = ballRadius;
var maxX;
var maxY;
var startDate;

function changeColor() {
    var chars = "456789abcdef",
        color = "";
    for (var i = 0; i < 2; i++) {
        var rnd = Math.floor(chars.length * Math.random());
        color += chars.charAt(rnd);
    }
    color = "#00" + color + '00';
    return color;
}

//Board move
var rightKey = false,
    leftKey = false,
    addLeft = boardSpeed,
    addRight = boardSpeed;

function setKeyControl() {
    if (rightKey) {
        boardX += addRight;

        if (boardX > 10 && boardX < 1050) {
            addLeft = boardSpeed;
        }

    } else if (leftKey) {
        boardX -= addLeft;

        if (boardX < 1190 && boardX > 0) {
            addRight = boardSpeed;
        }
    }

    if (boardX >= 1050) {
        addRight = 0;
    }

    if (boardX <= 0) {
        addLeft = 0;
    }
}

// Brick function
function Brick(x, y) {
    this.isDead = false;
    this.position = {
        x: x + wallMargin,
        y: y + wallMargin
    };

    this.rect = document.createElementNS(svgns, "rect");
    svg.appendChild(this.rect);
    this.rect.setAttribute("width", brickWidth);
    this.rect.setAttribute("height", brickHeight);
    this.rect.setAttribute("fill", "#00" + generateColor() + "00");
    this.rect.id = "brick" + x + y;
}

function generateColor() {
    var min = 0,
        max = 255;

    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function drawAndCollide(brick) {
    if (brick.isDead) {
        return;
    }

    // Drawing
    brick.rect.setAttribute("x", brick.position.x);
    brick.rect.setAttribute("y", brick.position.y);

    // Collision
    if (ballX + ballRadius < brick.position.x || ballX - ballRadius > brick.position.x + brickWidth) {
        return;
    }


    if (ballY + ballRadius < brick.position.y || ballY - ballRadius > brick.position.y + brickHeight) {
        return;
    }

    // Dead
    remove(brick);
    brick.isDead = true;
    destroyedBricksCount++;

    // Updating ball
    ballX = previousBallPosition.x;
    ballY = previousBallPosition.y;

    ballDirectionY *= -1.0;
};

// Killing a brick
function remove(brick) {
    if (brick.isDead) {
        return;
    }

    $(brick.rect).remove();
};

function generateBricks() {
    // Removing previous ones
    for (var index = 0; index < bricks.length; index++) {
        remove(bricks[index]);
    }

    for (var x = 0; x < bricksCols; x++) {
        for (var y = 0; y < bricksRows; y++) {
            bricks.push(new Brick(x * (brickWidth + bricksMargin), y * (brickHeight + bricksMargin) + bricksTop));
        }
    }
}

function setMouseControl() {

    boardX += boardSpeed;

    boardSpeed *= inertia;

    if (boardX < minX)
        boardX = minX;

    if (boardX + boardWidth > maxX) {
        boardX = maxX - boardWidth;
    }

}

registerMouseMove(document.getElementById("gameField"), function (posx, posy, previousX, previousY) {
    boardSpeed += (posx - previousX) * 0.2;
});

function moveBoard() {

    setKeyControl();
    setMouseControl();

    layer.clear();

    board.draw();
}

// Collisions
function collideWithWindow() {
    if (ballX < minX) {
        ballX = minX;
        ballDirectionX *= -1.0;
    }
    else if (ballX > maxX) {
        ballX = maxX;
        ballDirectionX *= -1.0;
    }

    if (ballY < minY) {
        ballY = minY;
        ballDirectionY *= -1.0;
        ball.setAttribute('fill', changeColor());
    }
    else if (ballY > maxY) {
        ballY = maxY;
        ballDirectionY *= -1.0;
        lost();
    }
}

function collideWithBoard() {
    if (boardY == (ballY + ballRadius) && boardX <= (ballX + ballRadius) && boardX + boardWidth >= (ballX + ballRadius)) {
        ballDirectionY *= -1.0;

        var dist = ballX - (boardX + boardWidth / 2);

        ballDirectionX = 2.0 * dist / boardWidth;

        var square = Math.sqrt(ballDirectionX * ballDirectionX + ballDirectionY * ballDirectionY);
        ballDirectionX /= square;
    }
}

// End of collisions

function checkWindow() {
    maxX = GAME_FIELD_WIDTH - minX;
    maxY = GAME_FIELD_HEIGHT - minY;
    //padY = maxY - 30;
}

function gameLoop() {

    //movePad();
    moveBoard();

    // Movements
    previousBallPosition.x = ballX;
    previousBallPosition.y = ballY;
    ballX += ballDirectionX * ballSpeed;
    ballY += ballDirectionY * ballSpeed;

    //// Collisions
    collideWithWindow();
    collideWithBoard();

    //// Bricks
    for (var index = 0; index < bricks.length; index++) {
        drawAndCollide(bricks[index]);
    }

    // Ball
    ball.setAttribute("cx", ballX);
    ball.setAttribute("cy", ballY);

    //// Pad
    //pad.setAttribute("x", padX);
    //pad.setAttribute("y", padY);

    //// Victory ?
    //if (destroyedBricksCount == bricks.length) {
    //    win();
    //}
}

var gameIntervalID = -1;

function lost() {
    clearInterval(gameIntervalID);
    gameIntervalID = -1;

    message.innerHTML = "Game over !";
    message.style.visibility = "visible";
}

function initGame() {
    message.style.visibility = "hidden";

    checkWindow();

    //padX = (window.innerWidth - padWidth) / 2.0;

    ballX = window.innerWidth / 2.0;
    ballY = maxY - 60;

    previousBallPosition.x = ballX;
    previousBallPosition.y = ballY;

    //padSpeed = 0;

    ballDirectionX = Math.random();
    ballDirectionY = -1.0;

    generateBricks();
    gameLoop();
}

function gameKays() {
    function keyDown(e) {

        if (e.keyCode == 39) {
            rightKey = true;
        }
        else if (e.keyCode == 37) {
            leftKey = true;
        }

        //moveBoard()
    }
    function keyUp(e) {

        if (e.keyCode == 39) {
            rightKey = false;
        }
        else if (e.keyCode == 37) {
            leftKey = false;
        }

        //moveBoard()
    }
    document.addEventListener('keydown', keyDown, false);
    document.addEventListener('keyup', keyUp, false);
}

function makeBrickSmall(){
    var positionX = 0,
        positionY = 0,
        widthOfBrick = brickWidth,
        heightOfBrick = brickHeight;
    setTimeout(function(){
        Brick(positionX * widthOfBrik, positionY * heightOfBrik + bricksTop);
        widthOfBrick -=10;
        heightOfBrick -10;
    }, 50);
}

function startGame() {
    gameKays();
    initGame();

    destroyedBricksCount = 0;

    if (gameIntervalID > -1)
        clearInterval(gameIntervalID);

    startDate = (new Date()).getTime();
    gameIntervalID = setInterval(gameLoop, 16);
}

document.getElementById("newGame").onclick = startGame;
window.onresize = initGame;

initGame();