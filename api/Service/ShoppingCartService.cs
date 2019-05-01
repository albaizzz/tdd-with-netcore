using System;
using System.Collections.Generic;
using api.Repositories;
using Microsoft.Extensions.Configuration;
using api.Models;

namespace api.Service
{
    public class ShoppingCartService : IShoppingCartService
    {
        private IShoppingCartRepository _shoppingRepository;
        private IConfiguration _config;
        public ShoppingCartService(IConfiguration config)
        {
            _config = config;
            _shoppingRepository = new ShoppingCartRepository(_config);
        }

        public List Add(List newItem){
            throw new NotImplementedException();
        }

        public IEnumerable<List> GetAllItems(){
            var results = _shoppingRepository.GetAllItems();
            return results;
        }
        public List GetById(int id){
            throw new NotImplementedException();
        }
        
        public void Remove(int id){
            throw new NotImplementedException();
        }
    }
}