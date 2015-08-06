using System.Collections.Generic;
using System.Linq;
namespace LMS.DataAccess
{
    public static class BooksOperations
    {
         static LibraryEntities entity = new LibraryEntities();  
        //method to view all books
        public static List<Book> ViewBook()
        {
            return (from Book in entity.Books
                         select Book).ToList();
        }
        //method to remove a book
        public static void DeleteBook(int id)
        {
            var query = (from Book in entity.Books
                         where Book.BookID == id
                         select Book).FirstOrDefault();
            entity.Books.Remove(query);
            entity.SaveChanges();
        }
        //method to update a book
        public static void UpdateBook(int id,string name,string author,string category,int quantity)
        {
            var query = (from Book in entity.Books
                         where Book.BookID == id
                         select Book).FirstOrDefault();
            query.Name = name;
            query.Author = author;
            query.Category = category;
            query.Quantity = quantity;
            entity.SaveChanges();   
        }
        //method to add a book
        public static void AddBook(int id, string name, string author, string category, int quantity)
        {
            Book newBook = new Book();
            newBook.BookID = id;
            newBook.Name = name;
            newBook.Author = author;
            newBook.Category = category;
            newBook.Quantity = quantity;
            entity.Books.Add(newBook);
            entity.SaveChanges();
        }
    }
}
