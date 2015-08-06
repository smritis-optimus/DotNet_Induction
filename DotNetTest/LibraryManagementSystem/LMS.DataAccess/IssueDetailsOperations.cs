using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess
{
   public static class IssueDetailsOperations
    {
       static LibraryEntities entity = new LibraryEntities();
       //method to issue a book
       public static void IssueBook(int id, string issuer)
       {
           var query = (from Book in entity.Books
                        where Book.BookID == id
                        select Book).FirstOrDefault();
           if (query.Quantity < 0)
           {
               query.Quantity = query.Quantity - 1;//quantity of book decremented when issued
               IssueDetail newIssue = new IssueDetail();
               newIssue.BookID = id;
               newIssue.Status = "Issued";
               newIssue.Issuer = issuer;
               newIssue.IssueDate = DateTime.Now;
               entity.SaveChanges();
           }
       }
       public static void WithDrawBook(int id, string issuer)
       {
           var query = (from Book in entity.Books
                        where Book.BookID == id
                        select Book).FirstOrDefault();
               query.Quantity = query.Quantity + 1;//quantity of book incrementec when withdrawn
               IssueDetail newIssue = new IssueDetail();
               newIssue.BookID = id;
               newIssue.Status = "Withdrawn";
               newIssue.Issuer = issuer;
               newIssue.IssueDate = DateTime.Now;
               entity.SaveChanges();
       }
    }
}
