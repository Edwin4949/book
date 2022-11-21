using ApplicationLayer.Interface;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer
{
    public class UserLoginInherit : IuserLogin
    {
        private readonly AppDbContext _appDbContext;
        public UserLoginInherit(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        

        public string ForgotPassword(string username)
        {
            throw new NotImplementedException();
        }

        public string Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void SignUp(UserRegister userRegister)
        {
            throw new NotImplementedException();
        }
    }
}
