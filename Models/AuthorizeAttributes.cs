using itvidpradotnetcoreadvanced.Models;
using System.Linq;

namespace itvidpradotnetcoreadvanced.Models
{
    public class AuthorizeAttributes
    {
       
        public void  OnExecuting()
        {
            //Logedin user - get user from session properties
            //userID - session
            LoginContext db = new LoginContext();
            List<UserRole> userroles = db.UserRoles.Where(x => x.userID = userID);
            if userroles.Contains(203)
    
            return ok
    
        else
                UnAuthorized

    }

    }
}
