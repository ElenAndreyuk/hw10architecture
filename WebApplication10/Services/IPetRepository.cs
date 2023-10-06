using WebApplication10.Models;

namespace WebApplication10.Services
{
    public interface IPetRepository : IRepository<Pet, int>
    {
    }
}
