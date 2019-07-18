
using System.Collections.Generic;
using api.Models;

namespace api.Repositories
{
    public interface IShoppingCartRepository
    {
<<<<<<< HEAD
        IEnumerable<Item> GetAllItems();
        int Add(Item newItem);
        Item GetById(int id);
        void Remove(int id);
=======
        IEnumerable<List> GetAllItems();
        int Add(List newItem);
        List GetById(int id);
        int Remove(int id);
>>>>>>> 1d7a49ce09ad6cc4ace189b246a8de7935e77445
    }
}