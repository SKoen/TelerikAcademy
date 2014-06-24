var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

Array.prototype.remove = function (number) {
    for (var index = 0; index < this.length; index++) {
        if (this[index] == number) {
            this.splice(index, 1)
        }
    }
   return this;
};

function start() {
    arr.remove(1);
    jsConsole.writeLine(arr);
    
}
