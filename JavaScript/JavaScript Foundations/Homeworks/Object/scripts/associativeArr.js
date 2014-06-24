/// <reference path="findPerson.js" />
/// <reference path="js-console.js" />
function group(people, prop) {
    switch (prop) {
        case "firstName":
        case "lastName":
        case "age":
            {
                var groups = {};

                people.map(function (p) {
                    if (!groups[p[prop]])
                        groups[p[prop]] = new Array();
                    groups[p[prop]].push(p);
                });

                return groups;
            }
        default:
            throw new Error("No such property in Person.");
    }
}

var persons = [
{ firstname: 'Gosho', lastname: 'Petrov', age: 32 },
{ firstname: 'Bay', lastname: 'Ivan', age: 81 },{ firstname: 'Kiro', lastname: 'Stoqnov', age: 15 },{ firstname: 'Stano', lastname: 'Lalov', age: 55 }];

var groupss = group(persons, "lastName");

for (var group in groupss) {
    jsConsole.writeLine("Group: " + group);
    for (var i = 0; i < groupss[group].length; i++) {
        jsConsole.writeLine("---Item " + groupss[group][i]);
    }
}
