using FinalProject.Models;
using System.Threading.Tasks;
namespace FinalProject.BL
{
    public interface IUsersBl
    {
        public Task<Users> getUser(string name, int password);
    }
}