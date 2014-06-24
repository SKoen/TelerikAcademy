/// <reference path="addnumber.js" />
/// <reference path="js-console.js" />

function binarySearch(value, low, high) {
    var array = numberArray;
    while (low <= high)
    {
        var middle = (low + high) / 2;
        if (array[middle] == value)
        {
            return middle;
        }
        else if (array[middle] > value)
        {
            high = middle - 1;
        }
        else
        {
            low = middle + 1;
        }
    }
    return "Not Found!"
}