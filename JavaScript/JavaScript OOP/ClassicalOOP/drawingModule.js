/**
 * Created by Sh0rti on 6/30/2014.
 */
'use strict';

var Draw = function(container){
    var ctx = document.getElementById(container).getContext("2d");
    ctx.fillStyle = 'red';
    ctx.strokeStyle = 'green';

    var line = function (x1, y1, x2, y2, width){
        ctx.beginPath();
        ctx.lineWidth = width | 2;
        ctx.moveTo(x1, y1);
        ctx.lineTo(x2, y2);
        ctx.stroke();
        ctx.lineWidth = 1;
        ctx.closePath();
    }

    var circle = function (x, y, radius, strikeColor){
        ctx.beginPath();
        ctx.strokeStyle = strikeColor || 'black';
        ctx.arc(x, y, radius, 0, 2*Math.PI);
        ctx.stroke();
        ctx.closePath();
    }

    var rect = function (x, y, width, height, fillColor){
        ctx.beginPath();
        ctx.fillStyle = fillColor || 'black';
        ctx.fillRect(x, y, width, height);
        ctx.closePath();
    }

    return {
        line: line,
        rect: rect,
        circle: circle
    }
};
