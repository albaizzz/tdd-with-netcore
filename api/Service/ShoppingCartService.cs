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
        private AppSetting _config;
        
        public ShoppingCartService(AppSetting config)
        {
            _config = config;
            _shoppingRepository = new ShoppingCartRepository(_config);
        }

        public int Add(Item newItem){
            var rowAffected = _shoppingRepository.Add(newItem);
            return rowAffected;
        }

        public IEnumerable<Item> GetAllItems(){
            var results = _shoppingRepository.GetAllItems();
            return results;
        }
        public Item GetById(int id){
            throw new NotImplementedException();
        }
        
        public void Remove(int id){
            try
            {
                 _shoppingRepository.Remove(id);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}