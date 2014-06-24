/// <reference path="js-console.js" />
var listOfPeople = [{ name: "gosho", age: 3 }, { name: "penio", age: 29 }, { name: "bat asen", age: 30 }];
var temp = document.getElementById("list-item").innerHTML;
var newArr = generateList(temp, listOfPeople);

for (var i = 0; i < newArr.length; i += 2) {
    jsConsole.writeLine("<ul><li><strong>" + newArr[i] + "</strong><span>" + newArr[i + 1] + "</span></li><li>…</li>…</ul>")
}

function generateList(temp, people) {
    var holder = temp;
    var liArr = [];
    for (var person in people) {
        var index = temp.indexOf("{name}");
        var index2 = temp.indexOf("{age}");
        temp = temp.replace("{name}", people[person].name);
        liArr.push(temp.substr(index, people[person].name.length) + " ");
        temp = holder;
        temp = temp.replace("{age}", people[person].age);
        liArr.push(temp.substr(index2, people[person].age.toString().length));
        temp = holder;
    }
    return liArr;
}