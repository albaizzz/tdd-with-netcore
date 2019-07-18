
using System.Collections.Generic;
using api.Models;

namespace api.Repositories
{
    public interface IShoppingCartRepository
    {
        IEnumerable<Item> GetAllItems();
        int Add(Item newItem);
        Item GetById(int id);
        void Remove(int id);
    }
}