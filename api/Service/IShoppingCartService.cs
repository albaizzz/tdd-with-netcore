using System;
using System.Collections.Generic;
using api.Models;

namespace api.Service{
    public interface IShoppingCartService
    {
        IEnumerable<Item> GetAllItems();
        int Add(Item newItem);
        Item GetById(int id);
        void Remove(int id);
    }
}