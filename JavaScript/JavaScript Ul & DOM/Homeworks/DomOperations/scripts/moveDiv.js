/**
 * Created by Sh0rti on 6/13/2014.
 */

var context = document.getElementById('context');
createDivs(5);
moveDivs(0);


function createDivs(count){
    var angle = 0;
    for(var i=0; i < count; i++){
        var x = Math.round(Math.cos(angle) * 100);
        var y = Math.round(Math.sin(angle) * 100);
        angle+=5;
        var item = document.createElement('div');
        item.style.border = "1px solid";
        item.style.borderRadius = "5px";
        item.style.width = "20px";
        item.style.height = "20px";
        item.style.position = "absolute";
        item.id = i;
        item.style.top = (200 + y) + "px";
        item.style.left = (300 + x) + "px";

        context.appendChild(item);
    }
}

var angle2 = 0;
function moveDivs(){
    angle2 += 0.3;

    for(var i = 0; i < 5; i++){
        var item = document.getElementById(i+"");

        item.style.left = (300 + 100 * Math.cos(angle2)) + "px";
        item.style.top = (200 + 100 * Math.sin(angle2)) + "px";

        angle2+=5;
    }

    setTimeout(moveDivs, 100);
}
