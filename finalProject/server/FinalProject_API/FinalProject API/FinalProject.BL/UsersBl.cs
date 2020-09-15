using FinalProject.DL;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class UsersBl : IUsersBl
    {
        IUsersDl usersDl;
        public UsersBl(IUsersDl _userDl)
        {
            usersDl = _userDl;
        }
        public async Task<Users> getUser(string name, int password)
        {
            return await usersDl.getUser(name, password);
        }
    }
}
