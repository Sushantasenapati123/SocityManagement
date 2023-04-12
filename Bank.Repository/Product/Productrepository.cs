using Bank.Domain.Product;
using Bank.Irepository.Product;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Product
{
    public class Productrepository : RepositoryBase,IproductRepository
    {
        public Productrepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<IEnumerable<ProductEntity>> listcat()
        {
            try
            {
                var query = "USP_productdetails";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "Cat");
                    var result = await Connection.QueryAsync<ProductEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return result;
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<ProductEntity>> listsubcat()
        {
            try
            {
                var query = "USP_productdetails";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "SubCat");
                    var result = await Connection.QueryAsync<ProductEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return result;
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<ProductEntity>> listproduct()
        {
            try
            {
                var query = "USP_productdetails";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "prod");
                    var result = await Connection.QueryAsync<ProductEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return result;
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insertProduct(ProductEntity rl)
        {
            throw new NotImplementedException();
        }

        public int insertsales(ProductEntity rl)
        {
            throw new NotImplementedException();
        }

    }
}
