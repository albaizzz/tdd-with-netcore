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
        private readonly AppSetting _config;

        public ShoppingCartRepository(AppSetting config){
            _config = config;
        }

        public IDbConnection Connection{
            get {
                return new SqlConnection(_config.ConnectionStrings.mysqlcon);
            }
        }

<<<<<<< HEAD
        public int Add(Item newItem)
        {
            int rowAffected;
            try
            {
                using(IDbConnection con = Connection){
                    con.Open();
                    var qry = "insert into List(name) values (@name)";
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@name", newItem.Name);
                    rowAffected= con.Execute(qry, param);
                }   
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return rowAffected; 
=======
        public int Add(List newItem)
        {
            using (IDbConnection con = Connection){
                try
                {
                    var qry = "insert into list (name) values(@name)";
                    con.Open();
                    var row = con.Execute(qry, new{newItem.Name});
                    return row;
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
>>>>>>> 1d7a49ce09ad6cc4ace189b246a8de7935e77445
        }

        public IEnumerable<Item> GetAllItems()
        {
            using(IDbConnection con = Connection){
                var qry = "select id, name from List";
                con.Open();
                var result = con.Query<Item>(qry);
                return result.AsEnumerable();
            }
            
        }

        public Item GetById(int id)
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