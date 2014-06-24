/**
 * Created by Sh0rti on 6/13/2014.
 */

//Create random generated divs
var divsCount = 20;
createDivs(divsCount);

function getRandomValue(min, max){
    var randomValue = (Math.random() * (max-min) + min) | 0;
    return randomValue;
}

function getRandomColor(){
    var red = getRandomValue(0, 255),
        green = getRandomValue(0, 255),
        blue = getRandomValue(0, 255);
    return "rgb(" + red + ", " + green + ", " + blue + ")";
}

function getRandomPosition(){
    var listPositions = ["absolute", "static", "fixed", "relative"],
        position = listPositions[getRandomValue(0,3)];
    return position;
}

function createDivs(count){
    var doc = document.body,
        docFragment = document.createDocumentFragment();

    for(var i=0; i < count; i++){
        var element = document.createElement('div');
        element.style.width = getRandomValue(20, 100) + "px";
        element.style.height = getRandomValue(20, 100) + "px";
        element.style.backgroundColor = getRandomColor();
        element.style.color = getRandomColor();
        element.style.position = getRandomPosition();
        element.innerHTML = "<strong>div</strong>";
        element.style.border = "2px solid";
        element.style.borderRadius = getRandomValue(5, 15) + "px";
        element.style.borderColor = getRandomColor();

        docFragment.appendChild(element);
    }

    doc.appendChild(docFragment);
}


