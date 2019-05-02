
using System.Collections.Generic;
using api.Models;

namespace api.Repositories
{
    public interface IShoppingCartRepository
    {
        IEnumerable<List> GetAllItems();
        List Add(List newItem);
        List GetById(int id);
        int Remove(int id);
    }
}