
var Student = (function () {

    var Student = function (firstName, lastName, age, marks) {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age;
        this._marks = marks.slice();
    };

    Student.prototype.getFirstName = function () {
        return this._firstName;
    };

    Student.prototype.getLastName = function () {
        return this._lastName;
    };

    Student.prototype.getAge = function () {
        return this._age;
    };

    Student.prototype.getMarks = function () {
        return this._marks;
    };

    return Student;
})();

var listOfStudents = [];
listOfStudents.push(new Student('Pesho', 'Kirov', 12, [4,6,6,6,6]));
listOfStudents.push(new Student('Gosho', 'Kirov', 15, [4,6,3,3,3]));
listOfStudents.push(new Student('Gosho', 'Georgiev', 20, [4,2,2,5,6]));
listOfStudents.push(new Student('Nokola', 'Stefanov', 19, [4,2,4,6]));
listOfStudents.push(new Student('Radoslav', 'Ivailov', 40, [4,6,5,3,6]));
listOfStudents.push(new Student('Stanislav', 'Sokolov', 60, [2,2,6,6,4]));
listOfStudents.push(new Student('Elisaveta', 'Nikolova', 18, [6,6,6,6,6]));
listOfStudents.push(new Student('Lubomir', 'Stavrov', 5, [4,5,5,5,6]));
listOfStudents.push(new Student('Spas', 'Spasov', 100, [4,3,3,5,4]));