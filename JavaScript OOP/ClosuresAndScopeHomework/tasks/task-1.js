/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [],
			categories = [];
		
		function validateTitle(title){
			if (title.length < 2 || title.length > 100) {
				throw new Error();
			}
		}
		
		function validateAuthor(author){
			if (author === '') {
				throw new Error();
			}
		}
		
		function validateISBN(isbn){
			if (isbn === 'undefined' || !(isbn.length === 10 || isbn.length === 13) || isNaN(isbn * 1)) {
				throw new Error();
			}
		}
		
		function listBooks(by) {
			var sortedBooks = [];
			if (!by || !Object.keys(by).length) {
				sortedBooks = books;
			} else if(by.hasOwnProperty('category') || by.hasOwnProperty('author')){
				sortedBooks = books.filter(function(book){
					return book.category === by.category || book.author === by.author;
				});
			}
			return sortedBooks;
		}
		
		function checkBookInList(newBook){
			return books.some(function(book){
				return book.title === newBook.title || book.isbn === newBook.isbn;
			});
		}
		
		function addCategory(newCategory){
			if (!categories.some(function(category){return newCategory === category})) {
				categories.push(newCategory);
			}
		}
		
		function addBook(book) {
			validateTitle(book.title);
			validateAuthor(book.author);
			validateISBN(book.isbn);
			if (checkBookInList(book)) {
				throw new Error();
			}
			book.ID = books.length + 1;
			books.push(book);
			addCategory(book.category);
			return book;
		}

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;