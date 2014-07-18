
var Book = (function () {

    var Book = function (name, author) {
        this._name = name;
        this._author = author;
    };

    Book.prototype.getName = function () {
        return this._name;
    };

    Book.prototype.getAuthor = function () {
        return this._author;
    };

    return Book;
})();

var listOfBooks = [];
listOfBooks.push(new Book('Inferno', 'Dan Brown'));
listOfBooks.push(new Book('The Lost Symbol', 'Dan Brown'));
listOfBooks.push(new Book('The Da Vinci Code ', 'Dan Brown'));
listOfBooks.push(new Book('Harry Potter and the Half-Blood Prince','J. K. Rowling'));
listOfBooks.push(new Book('Harry Potter and the Chamber of Secrets','J. K. Rowling'));
listOfBooks.push(new Book('Harry Potter and the Prisoner of Azkaban','J. K. Rowling'));
listOfBooks.push(new Book('Harry Potter and the Order of the Phoenix','J. K. Rowling'));