/**
 * Created by Sh0rti on 6/7/2014.
 */
var canvasDraw = document.getElementById("canvas-draws");
var draws = canvasDraw.getContext("2d");

    draws.beginPath();
    draws.save();
    draws.save();
    drawHead();
    draws.beginPath();
    draws.restore();
    drawHouse();
    draws.restore();
    draws.beginPath();
    drawBike();

function drawBike() {
    draws.fillStyle = "#90cad7";
    draws.strokeStyle = "#317a8c";
    draws.lineWidth = "2";
    draws.arc(100, 340, 40, 0, 2 * Math.PI);
    draws.stroke();
    draws.fill();
    draws.beginPath();
    draws.arc(280, 340, 40, 0, 2 * Math.PI);
    draws.stroke();
    draws.fill();
    draws.beginPath();
    draws.moveTo(100, 340);
    draws.lineTo(175, 340); //Here a ARC!
    draws.lineTo(270, 280);
    draws.lineTo(150, 280);
    draws.lineTo(100, 340);
    draws.moveTo(175, 340);
    draws.lineTo(140, 255);
    draws.lineTo(160, 255);
    draws.moveTo(140, 255);
    draws.lineTo(120, 255);
    draws.moveTo(280, 340);
    draws.lineTo(265, 250);
    draws.lineTo(215, 260);
    draws.moveTo(265, 250);
    draws.lineTo(300, 220);
    draws.stroke();
    draws.beginPath();
    draws.arc(175, 340, 15, 0, 2 * Math.PI);
    draws.stroke();
}
function drawHead() {

    draws.save();
    draws.save();
    //Draw Head ->Start
    draws.fillStyle = "#396693";
    draws.strokeStyle = "black";
    draws.lineWidth = "3";
    draws.fillRect(50, 50, 60, 80);
    draws.strokeRect(50, 50, 60, 80);
    draws.stroke();
    draws.scale(1, 0.4);
    draws.arc(80, 120, 30, 0, 2 * Math.PI);
    draws.fill();
    draws.moveTo(135, 330);
    draws.scale(1, 0.4);
    draws.arc(75, 825, 60, 0, 2 * Math.PI);
    draws.fill();
    draws.stroke();
    //Draw Head <- End
    draws.restore();
    draws.lineWidth = "2";
    draws.strokeStyle = "#317a8c";
    draws.beginPath();
    draws.fillStyle = "#90cad7";
    draws.moveTo(45, 142);
    draws.arc(75, 182, 50, 230 * Math.PI / 180, 302 * Math.PI / 180, true);
    draws.fill();
    draws.stroke();
    draws.moveTo(75, 182);
    draws.lineTo(65, 182);
    draws.lineTo(70, 165);
    draws.stroke();
    draws.beginPath();
    draws.rotate(10 * Math.PI / 180);
    draws.scale(1, 0.3);
    draws.arc(100, 650, 20, 0, 2 * Math.PI);
    draws.stroke();
    draws.beginPath();
    draws.restore();
    draws.strokeStyle = "#086A87";
    draws.fillStyle = "#086A87";
    draws.scale(1, 0.8);
    draws.arc(55, 200, 8, 0, 2 * Math.PI);
    draws.stroke();
    draws.beginPath();
    draws.arc(85, 200, 8, 0, 2 * Math.PI);
    draws.stroke();
    draws.beginPath();
    draws.scale(0.6, 1.5);
    draws.arc(88, 133, 4, 0, 2 * Math.PI);
    draws.fill();
    draws.beginPath();
    draws.arc(138, 133, 4, 0, 2 * Math.PI);
    draws.fill();
}
function drawHouse() {
    draws.fillStyle = "#975b5b";
    draws.strokeStyle = "black";
    draws.lineWidth = "4";
    draws.rect(400, 160, 270, 200);
    draws.stroke();
    draws.fill();
    //Roof
    draws.beginPath();
    draws.moveTo(400, 160);
    draws.lineTo(535, 30);
    draws.stroke();
    draws.lineTo(670, 160);
    draws.stroke();
    draws.lineTo(400, 160);
    draws.stroke();
    draws.fill();
    //Windows
    draws.beginPath();
    draws.fillStyle = "black";
    drawWindow(420, 190);
    drawWindow(550, 190);
    drawWindow(550, 270);
    //Door
    draws.lineWidth = "2";
    draws.beginPath();
    draws.moveTo(440, 360);
    draws.lineTo(440, 300);
    draws.moveTo(500, 360);
    draws.lineTo(500, 300);
    draws.stroke();
    draws.beginPath();
    draws.arc(470, 300, 30, 180 * Math.PI / 180, 365 * Math.PI / 180);
    draws.moveTo(470, 360);
    draws.lineTo(470, 270);
    draws.stroke();
    draws.beginPath();
    draws.arc(480, 335, 3.5, 0, 2 * Math.PI);
    draws.stroke();
    draws.beginPath();
    draws.arc(460, 335, 3.5, 0, 2 * Math.PI);
    draws.stroke();
    draws.beginPath();
    draws.lineWidth = "3";
    draws.fillStyle = "#975b5b";
    draws.moveTo(595, 130);
    draws.lineTo(595, 65);
    draws.lineTo(620, 65);
    draws.lineTo(620, 130);
    draws.stroke();
    draws.fill();
    draws.beginPath();
    draws.scale(1, 0.2);
    draws.arc(607, 325, 12, 0, 2 * Math.PI);
    draws.fill();
    draws.stroke();
}
function drawWindow(x, y){
    draws.rect(x, y, 50, 30);
    draws.fill();
    draws.rect(x, y+33, 50, 30);
    draws.fill();
    draws.rect(x+53, y+33, 50, 30);
    draws.fill();
    draws.rect(x+53, y, 50, 30);
    draws.fill();
}
