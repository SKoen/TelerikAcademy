window.onload = function load() {
    if(localStorage.length > 0) {
        digitModule.showClasation();
    }
    var button = document.getElementById('play-game'),
        digitArray = new Digits(),
        counter = 0;
    console.log(digitArray.getDigits());
    button.addEventListener('click', function () {
        counter = gameLogic(digitArray, counter);
    });
};

function gameLogic (digitArray, counter) {
    counter+=1;
    var result = new Digits(['?', '?', '?', '?']),
        digits,
        i;

    digits = new Digits([digitModule.getDigit('0'), digitModule.getDigit('1'),
        digitModule.getDigit('2'), digitModule.getDigit('3')]);

    for(i = 0; i < digitArray.getDigits().length; i++) {
        if(digitArray.getDigits()[i] === digits.getDigits()[i]) {
            result.setDigit(i, digits.getDigits()[i]);
        }
    }

    digitModule.setDigit('00', result.getDigits()[0]);
    digitModule.setDigit('11', result.getDigits()[1]);
    digitModule.setDigit('22', result.getDigits()[2]);
    digitModule.setDigit('33', result.getDigits()[3]);

    if(digitModule.checkForEquals(digits.getDigits(), result.getDigits())) {
        digitModule.openRegister(counter);
    }

    return counter;
}



