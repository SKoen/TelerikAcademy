
var Animal = (function () {

    var Animal = function (name, species, legs) {
        this._name = name;
        this._species = species;
        this._legs = legs || 4;
    };

    Animal.prototype.getName = function () {
        return this._name;
    };

    Animal.prototype.getSpecies = function () {
        return this._species;
    };

    Animal.prototype.getLegs = function () {
        return this._legs;
    };

    return Animal;
})();

var listOfAnimals = [];
listOfAnimals.push(new Animal('Squirrel','Mammals'));
listOfAnimals.push(new Animal('Marmot','Mammals'));
listOfAnimals.push(new Animal('Chipmunk','Mammals'));
listOfAnimals.push(new Animal('Rat','Mammals'));
listOfAnimals.push(new Animal('horse fly', 'Insects', 2));
listOfAnimals.push(new Animal('fly', 'Insects', 2));
listOfAnimals.push(new Animal('frog', 'Amphibians', 4));
listOfAnimals.push(new Animal('Salamander', 'Amphibians', 4));
listOfAnimals.push(new Animal('toad', 'Amphibians', 2));