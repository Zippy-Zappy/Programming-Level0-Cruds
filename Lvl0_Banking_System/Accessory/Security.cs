using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Accessory
{
    public static class Security
    {
        public static bool ActiveSession(object userSession)
        {
            User user = userSession != null ? (User)userSession : null;
            if (user != null)
                return true; else return false;
        }
    }
}
