using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectoryApp
{
    public class FindPhoneNumber
    {
        // PhoneDirectoryEntities is my entity container name
        private PhoneDirectoryEntities _context;

        //Constructor
        public FindPhoneNumber(PhoneDirectoryEntities context)

        {
            _context = context;
        }

        // method which returns the number for the passed name 
        public string LookupNumber(string userName)
        {
            var query = (from a in _context.PhoneNumbers 
                         where a.Name == userName 
                         select a).FirstOrDefault();
            return query.Number;
        }
    }
}
