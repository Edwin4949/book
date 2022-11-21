using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Interface
{
    public interface IuserLogin
    {
        string Login(string username, string password);
        void SignUp(UserRegister userRegister);
        string ForgotPassword(string username);
    }
}
