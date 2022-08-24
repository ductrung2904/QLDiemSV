using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV
{
    class UserRole
    {
        public string id;
        public string username;
        public string hoten;
        public UserRole()
        {
            id = ID;
            username = UserName;
            hoten = Hoten;
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
    }
}
