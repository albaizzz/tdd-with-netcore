using System.Reflection.Metadata.Ecma335;
using System;
using System.Net.Mime;
using api.Repositories;
using api.Models;

namespace test.Mocks
{
    public class ShoppingCartRepositoryMock : IShoppingCartRepository
    {
        private readonly List<ShoppingCartItem> _shoppingCart;
        
        public ShoppingCartRepositoryMock(){
            _shoppingCart = new List<ShoppingCartItem>{
                new ShoppingCartItem(){
                    Id = 1, Name = "1234"
                },
                new ShoppingCartItem(){
                    Id = 2, Name ="234"
                },
                new ShoppingCartItem(){
                    Id =3, Name = "12333"
                }
            };
        }

        public IEnumerable<List> GetAllItems(){
            
        }
        public int Add(List newItem){

        }
        public List GetById(int id){

        }
        public int Remove(int id){

        }
    }
}