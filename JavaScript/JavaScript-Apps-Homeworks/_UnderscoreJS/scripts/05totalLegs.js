function totalLegs (animals) {
    var totalLegs = 0;
    _.each(animals, function (animal) {totalLegs+=animal.getLegs()});
    console.log('Total number of legs: ' + totalLegs);
}

totalLegs(listOfAnimals);