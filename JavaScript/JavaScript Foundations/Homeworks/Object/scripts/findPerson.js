/// <reference path="js-console.js" />
var persons = [
{ firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
{ firstname: 'Bay', lastname: 'Ivan', age: 81 },{ firstname: 'Kiro', lastname: 'Stoqnov', age: 15 },{ firstname: 'Stano', lastname: 'Lalov', age: 55 }];var smollest = 0;for (var index = 0; index < persons.length; index++) {
    if (persons[smollest].age > persons[index].age) {
        smollest = index;
    }}jsConsole.writeLine(persons[smollest].firstname + " " + persons[smollest].lastname);