using System;
using System.Collections.Generic;
using api.Models;

namespace api.Service{
    public interface IShoppingCartService
    {
        IEnumerable<List> GetAllItems();
        List Add(List newItem);
        List GetById(int id);
        void Remove(int id);
    }
}