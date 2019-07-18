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

<<<<<<< HEAD
        public int Add(Item newItem){
            var rowAffected = _shoppingRepository.Add(newItem);
            return rowAffected;
=======
        public List Add(List newItem){
            try
            {
                var result = _shoppingRepository.Add(newItem);
                return newItem;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
>>>>>>> 1d7a49ce09ad6cc4ace189b246a8de7935e77445
        }

        public IEnumerable<Item> GetAllItems(){
            var results = _shoppingRepository.GetAllItems();
            return results;
        }
<<<<<<< HEAD
        public Item GetById(int id){
            throw new NotImplementedException();
=======
        public List GetById(int id){
            var results = _shoppingRepository.GetById(id);
            return results;
>>>>>>> 1d7a49ce09ad6cc4ace189b246a8de7935e77445
        }
        
        public void Remove(int id){
            try
            {
                var results = _shoppingRepository.Remove(id);
                if (results ==0){
                    throw new Exception("Data not found");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}