var findStudentsAndOrderByDecreasing = function (students) {
    var lastNameBefore = _.filter(students, function(item){
        return item.getFirstName().toLowerCase() < item.getLastName().toLowerCase() });

    var ordaredList = _.sortBy(lastNameBefore, '_firstName');

    _.each(ordaredList, function(item){
        console.log('Name: ' + item.getFirstName() + ' ' + item.getLastName());
    })
};

findStudentsAndOrderByDecreasing(listOfStudents);