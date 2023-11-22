using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchMovieTMS.AppData
{
    public partial class UserInformation
    {
        public int userInfoId { get; set; }
        public string userInfLname { get; set; }
        public string userInfFname { get; set; }
        public string userInfPhoneNum { get; set; }
        public string userInfEmail { get; set; }
        public Nullable<int> userId { get; set; }

        public virtual User User { get; set; }
    }
}
