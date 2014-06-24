/**
 * Created by Sh0rti on 6/13/2014.
 */
var wraper = document.getElementById('wraper');
createTextArea();
createColorInput("font-color");
createColorInput("background-color");

var fontColor = document.getElementById('font-color');
var backgroundColor = document.getElementById('background-color');

fontColor.addEventListener('change', changeFontColor, false);
backgroundColor.addEventListener('change',changeBackgroundColor, false);

function createTextArea(){
    var textArea = document.createElement('input');
    textArea.type = "text";
    textArea.size = 20;
    textArea.id = 'inputArea';

    wraper.appendChild(textArea);
}

function createColorInput(dataId){
    var color = document.createElement('input');
    color.type = "color";
    color.id = dataId;

    wraper.appendChild(color);
}

function changeFontColor(){
    var textArea = document.getElementById('inputArea');
    var color = document.getElementById('font-color');
    textArea.style.color = color.value;
}

function changeBackgroundColor(){
    var textArea = document.getElementById('inputArea');
    var color = document.getElementById('background-color');
    textArea.style.backgroundColor = color.value;
}
