using System;
using System.Collections.Generic;
using api.Models;
using api.Service;

namespace api.Service
{
    public class MockShoppingCartService : IShoppingCartService
    {
        List IShoppingCartService.Add(List newItem)
        {
            throw new NotImplementedException();
        }

        IEnumerable<List> IShoppingCartService.GetAllItems()
        {
            throw new NotImplementedException();
        }

        List IShoppingCartService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IShoppingCartService.Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}