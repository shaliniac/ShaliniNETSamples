using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseTestConsole;

namespace DatabaseTestConsole
{
    public class UserRights
    {
        private accountdbEntities _context;

        public UserRights(accountdbEntities context)
        {
            _context = context;
        }

        public string LookupPassword(string userName)
        {
            var query = (from a in _context.accounts
                         where a.username == userName
                         select a).FirstOrDefault();
            return query.password;
        }

    }
}
