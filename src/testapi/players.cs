

using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace testApi {
    public class players {
        private string username;
        private string dateJoined;
        private string email;
    

        public players( string name, string join, string email)
        {
            this.username = name;
            this.dateJoined = join;
            this.email = email;
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }


        public string DateJoined
        {
            get { return dateJoined; }
            set { dateJoined = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}