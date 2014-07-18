function animalsBySpecies (animals) {

    var grouped = _.groupBy(animals, '_species');
    var sortedAnimals = _.sortBy(grouped, '_legs');
    console.dir(sortedAnimals)
}

animalsBySpecies(listOfAnimals);