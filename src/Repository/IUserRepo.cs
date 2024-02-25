using Model;

namespace Repository
{
    public interface IUserRepo
    {
        Task<List<User>> Query();
    }
}
