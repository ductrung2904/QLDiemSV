using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV
{
    class UserRole
    {
        public string username;
        public UserRole()
        {
            username = UserName;
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
    }
}
