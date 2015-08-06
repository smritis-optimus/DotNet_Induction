using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess
{
    public static class ValidLogin
    {
        //check if admin is valid or not
        public static bool IsAdmin(string username, string password)
         {
             LibraryEntities entity = new LibraryEntities();
             var query = (from Admin in entity.Admins
                          where Admin.Username == username && Admin.Password == password
                          select Admin).FirstOrDefault();
             if (query != null)
             {
                 return true;
             }
             else
                 return false;
         }
        //check if user is valid or not
        public static bool IsUser(string username, string password)
         {
             LibraryEntities entity = new LibraryEntities();
             var query = (from Student in entity.Students
                          where Student.Username == username && Student.Password == password
                          select Student).FirstOrDefault();
             if (query != null)
             {
                 return true;
             }
             else
                 return false;
         }
    }
}
