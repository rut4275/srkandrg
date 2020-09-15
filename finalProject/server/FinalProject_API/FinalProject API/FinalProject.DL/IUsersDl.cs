using FinalProject.Models;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public interface IUsersDl
    {
        public Task<Users> getUser(string name, int password);
    }
}