using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetrolBunkManagement.src
{
    interface DatabaseInterface
    {
       bool Login(string iUsrename, string ipassword);
    }
}
