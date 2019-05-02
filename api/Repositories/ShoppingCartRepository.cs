using System.Linq;
using Dapper;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using api.Models;
using System.Data;
using System.Data.SqlClient;


namespace api.Repositories
{
    
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly IConfiguration _config;

        public ShoppingCartRepository(IConfiguration config){
            _config = config;
        }

        public IDbConnection Connection{
            get {
                return new SqlConnection(_config.GetConnectionString("mysqlcon"));
            }
        }

        public List Add(List newItem)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<List> GetAllItems()
        {
            using(IDbConnection con = Connection){
                var qry = "select id, name from List";
                con.Open();
                var result = con.Query<List>(qry);
                return result.AsEnumerable();
            }
            
        }

        public List GetById(int id)
        {
            using(IDbConnection con = Connection){
                var qry = "select id, name from List where id = @id";
                con.Open();
                var result = con.QueryFirstOrDefault<List>(qry, new{id});
                return result;
            }
        }

        public int Remove(int id)
        {
            using(IDbConnection con = Connection){
                var qry = "delete List where id = @id";
                con.Open();
                var rows = con.Execute(qry, new{id});
                return rows;
            }
        }
    }
}