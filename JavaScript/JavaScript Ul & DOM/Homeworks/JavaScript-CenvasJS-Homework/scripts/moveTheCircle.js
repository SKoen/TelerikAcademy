/**
 * Created by Sh0rti on 6/8/2014.
 */
var canvas = document.getElementById("canvas-draws");
var circle = canvas.getContext("2d");

var x = 70,
    y = 20,
    addX = 3,
    addY = 3,
    speed = 3;

circle.beginPath();
move();

function move(){
    x+=addX;
    y+=addY;
    circle.arc(x,y, 10, 0, 2*Math.PI);
    circle.stroke();

    if(y >= 390 && addX > 0){
        addX = speed;
        addY = -speed;
    }
    if(y >= 390 && addX < 0){
        addX = -speed;
        addY = -speed;
    }
    if(x >= 690 && addY < 0){
        addX = -speed;
        addY = -speed;
    }
    if(x >= 690 && addY > 0){
        addX = -speed;
        addY = speed;
    }
    if(x <= 10 && addY < 0){
        addX = speed;
        addY = -speed;
    }
    if(x <= 10 && addY > 0){
        addX = speed;
        addY = speed;
    }
    if(y <= 10 && addX < 0){
        addX = -speed;
        addY = speed;
    }
    if(y <= 10 && addX > 0){
        addX = speed;
        addY = speed;
    }
    requestAnimationFrame(move);
}
