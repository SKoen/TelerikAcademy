function mostCommonNAme (people) {
    var mostCommonFirstName = getMostCommentNames(people, '_firstName');
    var mostCommonLastName = getMostCommentNames(people, '_lastName');
    console.log("Most Common First Name: " + mostCommonFirstName.name + ' -> ' + mostCommonFirstName.count);
    console.log("Most Common Last Name: " + mostCommonLastName.name + ' -> ' + mostCommonLastName.count);
}

function getMostCommentNames (people, name) {
    return _.chain(people)
        .countBy(name)
        .pairs()
        .map(function (arr) {
            return {
                name: arr[0],
                count: arr[1]
            };
        })
        .max(function (obj) {
            return obj.count
        })
        .value();
}

mostCommonNAme(listOfStudents);