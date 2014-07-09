'use strict';

var domModule = function(){
    var bufferArray = {};

    function appendChild(element, id){
        var parent = document.querySelector(id);
        parent.appendChild(element.cloneNode(true));
    }

    function removeChild(parent, elementToRemove){
        var parent = document.querySelector(parent);
        var child = document.querySelector(elementToRemove);
        parent.remove(child);
    }

    function addHandler(element, event, makeSomething){
        var thisElement = document.querySelector(element);
        thisElement.addEventListener(event, makeSomething);

    }

    function appendToBuffer(parent, element){
        var parent = document.querySelector(parent);
        for(var i =0; i<bufferArray.length; i++){
            if(i == bufferArray.length -1){
                if(bufferArray[i].name != parent){
                    bufferArray[i].name = parent + "";
                }

            }
            if(bufferArray[i].name == parent){
               break;
            }
        }

        bufferArray[parent].appendChild(element);
        if(bufferArray[parent].length == 100){
            parent.appendChild(bufferArray[parent]);
        }

    }

    function getElementByCSSSelector(selector){
        var elements = document.querySelector('body').childNodes;
        for(var child in elements){
            if(child.getAttribute(selector)){
                return child;
            }
        }
    }

    return {
        appendChild: appendChild(),
        removeChild: removeChild(),
        addHandler: addHandler(),
        appendToBuffer: appendToBuffer(),
        getElementByCSSSelector: getElementByCSSSelector()
    }
};