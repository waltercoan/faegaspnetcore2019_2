using myshop.Models;

namespace myshop.Services
{
    public interface IUserService
    {
         User getUserByName(string name);
         User save(User user);
    }
}