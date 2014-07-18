function studentsHighestMarks (students) {
    var studentsMarks = _.map(students, function (item) {
        var sumOfMarks = 0;
        _.each(item.getMarks(), function (number) {
            sumOfMarks += Number(number)
        });
        return {
            name: item.getFirstName() + ' ' + item.getLastName(),
            age: item.getAge(),
            sumOfMarks: sumOfMarks/item.getMarks().length
        }
    });

    var sortByMarks = _.sortBy(studentsMarks, 'sumOfMarks');
    console.log(sortByMarks.reverse());
}

studentsHighestMarks(listOfStudents);