using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indkoebskurv
{
    public class User
    {
        #region Fields - klassens indkapslede egenskaber
        private string username;
        private string firstname;
        private string lastname;
        private int role;
        #endregion

        #region Constructors - klassens konstruktør(er)
        public User()
        {
            //
            // TODO: Add logic constructors here
            //
        }
        #endregion

        #region Properties - klassens offentlige adgang til de indkapslede fields

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        public string Lastname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public int Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        /// <summary>
        /// Konstruerer en User og sætter værdier til de fire fields
        /// </summary>
        /// <param name="username">Skriv brugerens brugernavn</param>
        /// <param name="firstname">Skriv brugerens fornavn</param>
        /// <param name="lastname">Skriv brugerens efternavn</param>
        /// <param name="role">Skriv brugerens tal der svarer til rollen</param>
        public User(string username, string firstname, string lastname, int role)
        {
            //her overføres værdierne til de fire fields
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.role = role;
        }
        #endregion

        #region Methods - klassens offentlige metoder
        public static bool IsUser()
        {
            bool result = false;

            if(HttpContext.Current.Session["user"] != null)
            {
                result = true;
            }

            return result;
        }

        public static void CreateSession()
        {
            if (HttpContext.Current.Session["user"] == null)
            {
                HttpContext.Current.Session.Add("user", "noname");
            }
        }

        public static void RemoveSession()
        {
            if (HttpContext.Current.Session["user"] != null)
            {
                HttpContext.Current.Session.Remove("user");
            }
        }
        #endregion
    }
}