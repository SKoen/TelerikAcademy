function checkNeighbors(position, array) {
    if (position > array.length-1) {
        return "Not number on that Position";
    }
    if (array[position-1] < array[position] && array[position] > array[position+1] ) {
        return "Bigger";
    } else {
        return "Smaller";
    }
}