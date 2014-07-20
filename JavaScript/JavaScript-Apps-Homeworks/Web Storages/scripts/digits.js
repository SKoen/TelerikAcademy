var Digits = (function () {

    //Private
    function generateDigits() {
        var digitArray = [],
            number,
            isCorrect,
            i,
            j;
        digitArray[0] = 0;
        for(i = 1; i < 4; i++) {
            number = Math.floor((Math.random() * 9) + 0);
            for(j = 0; j < digitArray.length; j++) {
                if(number === digitArray[j]){
                    isCorrect = false;
                }
            }
            if(isCorrect) {
                digitArray[i] = number;
            }
            else {
                i--;
                isCorrect = true;
            }
        }

        return digitArray;
    }

    //Public
    var Digits = function (args){
        if(args !== undefined) {
            this.array = args.slice(0);
        }
        else {
            this.array = generateDigits().slice(0);
        }
    };

    Digits.prototype.getDigits = function () {
        return this.array;
    };

    Digits.prototype.setDigit = function (index, value) {
        this.array[index] = value;
    };

    return Digits;
})();