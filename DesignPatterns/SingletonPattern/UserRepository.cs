using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class UserRepository
    {
        private static UserRepository _userRepository;

        private UserRepository()
        {

        }

        public static UserRepository Instance
        {
            get
            {
                if (_userRepository == null)
                {
                    return new UserRepository();
                }

                return _userRepository;
            }
        }

        public object GetUser(string login)
        {
            return new object();
        }
    }
}
