using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Helper
{
    public interface IUserRepository
    {
        IList<User> GetAll();
        void Add(User user);
        void Update(User user);
    }
}
