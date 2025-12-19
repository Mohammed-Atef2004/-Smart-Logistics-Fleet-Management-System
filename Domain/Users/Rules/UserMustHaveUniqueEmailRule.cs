using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Rules
{
    public class UserMustHaveUniqueEmailRule
    {
        //will be modified to use repository pattern in future
        private readonly Func<string, bool> _emailExistsFunc;
        public UserMustHaveUniqueEmailRule(Func<string, bool> emailExistsFunc)
        {
            _emailExistsFunc = emailExistsFunc;
        }
        public bool IsSatisfied(string email)
        {
            return !_emailExistsFunc(email);
        }
    }
}
