using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchMovieTMS.AppData
{
    public partial class User
    {
        public User() { this.UserInformation = new HashSet<UserInformation>(); }

        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public Nullable<int> userType { get; set; }
        public Nullable<int> createdBy { get; set; }

        public virtual ICollection<UserInformation> UserInformation { get; set; }
    }
}
