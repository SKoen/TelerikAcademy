/**
 * Created by Sh0rti on 6/13/2014.
 */
var todoList = document.getElementById('list'),
    addButton = document.getElementById('button-for-add'),
    removeButton = document.getElementById('button-for-remove'),
    showOrHideButton = document.getElementById('button-show-hide');

addButton.addEventListener('click', function(ev){
    var item = document.createElement('li');
    item.innerText = document.getElementById('input-text').value;

    todoList.appendChild(item);
});

removeButton.addEventListener('click', function(ev){
    var name = document.getElementById('input-text').value;
    for(var i= 0, length = todoList.childNodes.length; i < length; i++){
        if(name === todoList.childNodes[i].innerText){
            todoList.removeChild(todoList.childNodes[i]);
            break;
        }
    }
});

showOrHideButton.addEventListener('click', function(ev){
    var dispay = todoList.style.display;
    if(dispay === "none"){
        dispay = 'inline-block';
    }
    else{
        dispay = 'none';
    }

    todoList.style.display = dispay;
});
