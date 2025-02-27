// Classes
using src.LibraryManagement;

//********* Step 1 *********//
Books myBook = new Books();
Console.WriteLine($"Book: {myBook.Author}");

myBook.Title = "1Q84";
myBook.Author = "Haruki Murakami";

Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

//