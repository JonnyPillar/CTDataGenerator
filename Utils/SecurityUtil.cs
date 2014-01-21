using System.Web.Security;

namespace CTDataGenerator.Utils
{
    public class SecurityUtil
    {
        /// <summary>
        /// Add Auth Cookie For User
        /// </summary>
        /// <param name="userID">User ID</param>
        public static void AddAuthCookieForUser(string userID)
        {
            FormsAuthentication.SetAuthCookie(userID, true);
        } 

        /// <summary>
        /// Is a paassword entered by a user valid
        /// </summary>
        /// <param name="usersPasswordHash">Password Hash From DB</param>
        /// <param name="usersPasswordSalt">Password Salt From DB</param>
        /// <param name="passwordStringToCheck">Password Entered By User</param>
        /// <returns>Valid Password?</returns>
        public static bool IsPasswordValid(string passwordStringToCheck, string usersPasswordSalt, string usersPasswordHash)
        {
            PasswordHasher passwordHasher = new PasswordHasher(passwordStringToCheck, usersPasswordSalt);
            return passwordHasher.PasswordHash.Equals(usersPasswordHash);
        }
    }
}
