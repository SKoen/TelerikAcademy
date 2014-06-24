/**
 * Created by Sh0rti on 6/16/2014.
 */
var studentsArr = [{
    firstName: 'Peter',
    lastName: 'Ivanov',
    grade: 3
},
    {
        firstName: 'Milena',
        lastName: 'Grigorieva',
        grade: 6
    },
    {
        firstName: 'Gergana',
        lastName: 'Borisova',
        grade: 12
    }];

//Test Function
generateTable(studentsArr, '#wrapar')

function generateTable(students, element){
    var $elements = $('<tr>').append($('<td>').text('First Name'))
                       .append($('<td>').text('Last Name'))
                       .append($('<td>').text('Grade'));
    var table = $('<table>').append($elements).attr('border', '1');

    for(var i = 0, length = students.length; i < length; i++){
        var $elements = $('<tr>').append($('<td>').text(students[i].firstName))
                            .append($('<td>').text(students[i].lastName))
                            .append($('<td>').text(students[i].grade));

        table.append($elements);
    }

    $(element).append(table.append($elements).attr('border', '1'));
}