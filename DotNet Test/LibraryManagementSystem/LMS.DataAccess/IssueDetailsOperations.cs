using System;
using System.Linq;

namespace LMS.DataAccess
{
   public static class IssueDetailsOperations
    {
       /// <summary>
       /// method to issue a book
       /// </summary>
       /// <param name="id">Book id</param>
       /// <param name="issuer">username of student/issuer</param>
       public static void IssueBook(int id, string issuer)
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
                       if (query.Quantity > 0)
                       {
                           query.Quantity = query.Quantity - 1;//quantity of book decremented when issued
                           IssueDetail newIssue = new IssueDetail();
                           newIssue.BookID = id;
                           newIssue.Issuer = issuer;
                           newIssue.IssueDate = DateTime.Now;
                           newIssue.WithdrawDate = null;
                           entity.IssueDetails.Add(newIssue);
                           entity.SaveChanges();
                       }
                   }
               }
           }
           catch (Exception e)
           {
           }
       }
       /// <summary>
       /// method to withdraw a book and save record in issuedetail
       /// </summary>
       /// <param name="id">Issue id</param>
       public static void WithDrawBook(int id)
       {
           try
           {
               using (LibraryEntities entity = new LibraryEntities())
               {
                   var query = (from IssueDetail in entity.IssueDetails
                                where IssueDetail.IssueID == id
                                select IssueDetail).FirstOrDefault();
                   if (query != null)
                   {
                       query.WithdrawDate = DateTime.Now;//withdraw date is updated
                       int bookId = Convert.ToInt32(query.BookID);//take the respective bookid to increment its quantity in book table
                       var queryBook = (from Book in entity.Books
                                        where Book.BookID == bookId
                                        select Book).FirstOrDefault();
                       if (queryBook != null)
                       {
                           queryBook.Quantity = queryBook.Quantity + 1;//quantity of book incrementec when withdrawn
                           entity.SaveChanges();
                       }
                       entity.SaveChanges();
                   }
               }
           }
           catch (Exception e)
           {
           }
       }
    }
}
