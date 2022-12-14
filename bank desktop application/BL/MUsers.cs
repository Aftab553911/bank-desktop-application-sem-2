using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_desktop_application.BL
{
  public  class MUsers
    {
        private string username;
        private string password;
        private string roll;
        internal List<user_details> User_related { get => user_related; set => user_related = value; }
        private List<user_details> user_related = new List<user_details>();
        public MUsers()
        {

        }
        public MUsers(string username, string password, string roll)
        {
            this.username = username;
            this.password = password;
            this.roll = roll;
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Roll { get => roll; set => roll = value; }

    }
}
