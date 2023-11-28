using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchMovieTMS.AppData;

namespace WatchMovieTMS
{
    public class UserLogged
    {
        private static UserLogged _instance;

        public User User { get; set; }
        private UserLogged() { }

        public static UserLogged GetInstance() {
            if (_instance == null)
                _instance = new UserLogged();
            return _instance;
        }
    }
}
