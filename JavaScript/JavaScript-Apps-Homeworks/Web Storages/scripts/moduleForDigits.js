var digitModule = (function () {

    function getDigit(id) {
        return Number(document.getElementById(id).value);
    }

    function setDigit(id, value) {
        if(value !== '?'){
            document.getElementById(id).value = value;
            document.getElementById(id).className = 'correct';
        }
        else {
            document.getElementById(id).value = value;
            document.getElementById(id).className = '';
        }
    }

    function checkForEquals(input, result) {
        var i;
        for(i = 0; i < input.length; i++) {
            if(Number(input[i]) !== Number(result[i])) {
                return false;
            }
        }

        return true;
    }

    function openRegister(trys) {
        var attachTo = document.getElementById('register');
        var label = document.createElement('label');
        var name = document.createElement('input');
        var button = document.createElement('button');
        label.innerText = 'Enter Your Name';
        name.className = 'name';
        button.className = 'load-register';
        button.innerText = 'Register';
        attachTo.appendChild(label);
        attachTo.appendChild(name);
        attachTo.appendChild(button);
        console.log(trys);
        console.log(typeof trys);
        console.log(typeof trys+'');
        button.addEventListener('click', function () {
            registerInStorage(name.value, trys+'');
        });
    }

    function registerInStorage (name, value) {
        localStorage.setItem(name, value);
    }

    function showClasation() {
        var item = document.createElement('li'),
            div = document.getElementById('clasation'),
            i;

        for(i = 0; i < localStorage.length; i++) {
            var kay = localStorage.key(i);
            var newItem = item.cloneNode(true);
            newItem.innerText = kay + ' -> ' + localStorage.getItem(kay);
            div.appendChild(newItem);
        }

    }

    return {
        getDigit: getDigit,
        setDigit: setDigit,
        checkForEquals: checkForEquals,
        openRegister: openRegister,
        showClasation: showClasation
    }

})();