/**
 * Created by Sh0rti on 7/4/2014.
 */
'use strict';

var Snake = function(ctx){

    //Private
    var draw,
        move;

    //Public
    draw = function(snakeCordinates){
        var partWidth = 2,
            length = snakeCordinates.length;

        ctx.strokeStyle = "F6214D";
        ctx.beginPath();
        for(var i = 0; i < length; i++){
            ctx.arc(snakeCordinates[i].x, snakeCordinates[i].y, partWidth, 0, 2*Math.PI);
            ctx.stroke();
        }

    };

    move = function(snakeCordinates, direction){
        var move = 10,
            x = snakeCordinates[0].x,
            y = snakeCordinates[0].y,
            length = snakeCordinates.length,
            x1, y1;

        if(direction == 'right'){
           snakeCordinates[0].x += move;
        }
        else if(direction == 'left'){
            snakeCordinates[0].x -= move;
        }
        else if(direction == 'up'){
            snakeCordinates[0].y -= move;
        }
        else if(direction == 'down'){
            snakeCordinates[0].y += move;
        }

        for(var i = 1; i < length; i++){
            x1 = snakeCordinates[i].x;
            y1 = snakeCordinates[i].y;
            snakeCordinates[i].x = x;
            snakeCordinates[i].y = y;
            x = x1;
            y = y1;
        }

        return snakeCordinates;
    };

    return{
        draw: draw,
        move: move
    }

};