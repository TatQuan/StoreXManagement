using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreXManagement
{
    public class User
    {
        public string UserName { get; set; }
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Access { get; set; }

        public User() { }

        public User(int empID, string empName, string access, string userName  )
        {
            EmpID = empID;
            EmpName = empName;
            Access = access;
            UserName = userName;
        }
    }
}
