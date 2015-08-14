using System.Collections.Generic;
using System.Linq;
using System;
namespace LMS.DataAccess
{
    public static class BooksOperations
    { 
        /// <summary>
         /// method to view all books to admin and user
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetBook()
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    return (from Book in entity.Books
                            select Book).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// method to remove a selected book by bookid
        /// </summary>
        /// <param name="id">bookid</param>
        public static void DeleteBook(int id)
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    var query = (from Book in entity.Books
                                 where Book.BookID == id
                                 select Book).FirstOrDefault();
                    if (query != null)
                    {
                        entity.Books.Remove(query);
                        entity.SaveChanges();
                    }
                    else
                    {
                       
                    }
                }
            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// method to update a book
        /// </summary>
        /// <param name="id">bookId</param>
        /// <param name="name">name of book</param>
        /// <param name="author">author of book</param>
        /// <param name="category">category of book</param>
        /// <param name="quantity">quantity of book</param>
        public static void UpdateBook(int id, string name, string author, string category, int quantity)
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    var query = (from Book in entity.Books
                                 where Book.BookID == id
                                 select Book).FirstOrDefault();
                    if (query != null)
                    {
                        query.Name = name;
                        query.Author = author;
                        query.Category = category;
                        query.Quantity = quantity;
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// method to add a book
        /// </summary>
        /// <param name="id">Book id</param>
        /// <param name="name">name of book</param>
        /// <param name="author">author of book</param>
        /// <param name="category">category of book(fiction,non-fiction etc)</param>
        /// <param name="quantity"></param>
        public static void AddBook(int id, string name, string author, string category, int quantity)
        {
            try
            {
                Book newBook = new Book();
                newBook.BookID = id;
                newBook.Name = name;
                newBook.Author = author;
                newBook.Category = category;
                newBook.Quantity = quantity;
                using (LibraryEntities entity = new LibraryEntities())
                {
                    entity.Books.Add(newBook);
                    entity.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
