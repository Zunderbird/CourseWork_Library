using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_01
{
    class UserData
    {
        private static UserData instance;

        public string login="";
        private bool _logged;
        public string role = UNLOGGED;
        public int user_id = 0;
     

       public static string ADMIN = "ADMIN";
       public static string EDITOR = "EDITOR";
       public static string SPY = "SPY";
       public static string READER = "READER";
       public static string UNLOGGED = "UNLOGGED";
       public static string PERSONAL = "PERSONAL";

       public event System.EventHandler LoggedChange;
        
        private UserData() { }

        public static UserData getInstance
        {
            get  {
                     if (instance == null)
                     {
                         instance = new UserData();
                     }
            return instance;
                  }
        }

        public bool logged
        {
            set { 
                this._logged = value;
                onLoggedStatusChange();
            }
            get { return this._logged; }
        }

        protected virtual void onLoggedStatusChange()
        {
            if (LoggedChange != null) { 
                LoggedChange(this, EventArgs.Empty);
            }
        }
  }
}
