function sortStudentByAge (students) {
    var studetsByAge = _.filter(students, function(item){
        return item.getAge() >= 18 && item.getAge() <= 24 });

    _.each(studetsByAge, function(item){
        console.log('Name: ' + item.getFirstName() + ' ' + item.getLastName());
    })
}

sortStudentByAge(listOfStudents);