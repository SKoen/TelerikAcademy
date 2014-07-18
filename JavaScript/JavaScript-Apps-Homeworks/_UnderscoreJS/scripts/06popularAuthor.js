function popularAuthor(books) {
    var authors = _.groupBy(books, '_author');
    var mostPopularAuthor = _.max(authors, function(item){ return item.length});

    console.log('Author: ' + mostPopularAuthor[0].getAuthor() + '\nbooks: ' + mostPopularAuthor.length);
}

popularAuthor(listOfBooks);