using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchMovieTMS.AppData;

namespace WatchMovieTMS
{
    public class UserRepository
    {
        private movieTicketManagementEntities db;
        public UserRepository() { db = new movieTicketManagementEntities(); }

        public ErrorCode NewUser(User aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.User.Add(aUserAccount);
                db.SaveChanges();

                outMessage = "Inserted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public ErrorCode UpdateUser(int? userId, User aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                User user = db.User.Where(m => m.userID == userId).FirstOrDefault();
                // Update the value of the retrieved user
                user.userName = aUserAccount.userName;
                user.password = aUserAccount.password;

                db.SaveChanges();       // Execute the update

                outMessage = "Updated";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Success;
                MessageBox.Show(ex.Message);
            }
            return retValue;

        }

        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                User user = db.User.Where(m => m.userID == userId).FirstOrDefault();
                // Remove the user
                db.User.Remove(user);
                db.SaveChanges();       // Execute the update

                outMessage = "Deleted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public User GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new movieTicketManagementEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.User.Where(s => s.userName == username).FirstOrDefault();
            }
        }
        public List<User> UserAccounts()
        {
            using (db = new movieTicketManagementEntities())
            {
                return db.User.ToList();
            }
        }
        public List<vw_Users> AllUserRole()
        {
            using (db = new movieTicketManagementEntities())
            {
                return db.vw_Users.ToList();
            }
        }

        public ErrorCode CreateUserUsingStoredProf(String username, String password, int role, ref String szResponse)
        {
            try
            {
                using (db = new movieTicketManagementEntities())
                {
                    // Call the create stored procedure
                    //
                    db.sp_addUsers(username, password, role);
                    szResponse = "Created";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                szResponse = ex.Message;
                return ErrorCode.Error;
            }
        }


    }
}
