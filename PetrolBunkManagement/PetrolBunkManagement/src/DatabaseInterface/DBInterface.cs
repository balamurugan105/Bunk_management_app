﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetrolBunkManagement.src.DatabaseInterface
{
    interface DBInterface
    {
        bool Login(string iusrname,string ipassword);
        bool isReportsViewAllowed(string iUsrName);
        List<string> getList(string iQueryCommand);
    }
}
