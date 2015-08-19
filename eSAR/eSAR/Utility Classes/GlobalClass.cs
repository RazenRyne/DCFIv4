using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSAR.UserServiceRef;
namespace eSAR.Utility_Classes
{
    public class GlobalClass
    {
        LoggedUser user;
        public LoggedUser UserLoggedIn
        {
            get { return user; }
            set { user = value; }
        }
        public void GetUser(User u) {
            user = new LoggedUser();
            user.FirstName = u.FirstName;
            user.LastName = u.LastName;
            user.MiddleName = u.MiddleName;
            user.UserId = u.UserId;
            user.UserType = u.UserTypeCode;
            user.TimeLoggedIn = DateTime.Now;
        }
    }

   public class LoggedUser {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string UserType { get; set; }
        public DateTime TimeLoggedIn { get; set; }
    }

}


