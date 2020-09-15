using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public class UsersDl : IUsersDl
    {
        FinalProjectContext context;
        public UsersDl(FinalProjectContext _context)
        {
            context = _context;
        }
        public async Task<Users> getUser(string name, int password)
        {
            return await context.Users.Where(u => u.UserName == name && u.UserPassword == password).FirstOrDefaultAsync();
        }
    }
}
